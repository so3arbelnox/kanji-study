using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiApp
{
    public partial class StudyForm : Form
    {
        private int currentCard = 0;
        private ToolTip cardToolTip = new ToolTip();

        public enum StudyMode
        {
            FRONT = 0,
            BACK = 1
        }

        public enum StudyOption
        {
            AMOUNT = 0,
            ALL = 1
        }

        public StudyMode CurrentStudyMode { get; set; }
        public bool ShuffleDeck { get; set; }
        public bool UseRange { get; set; }

        public bool ReverseCard { get; set; }

        public bool HideHiragana { get; set; }

        // If range selected
        public int CardIndexStart { get; set; }
        public int CardIndexEnd { get; set; }

        List<Card> repeatCards = new List<Card>();
        List<Card> cards; // Cloned list of cards

        public StudyForm(StudyOption studyOption, int start, int end, int amount, bool reverseCard = false, bool hideHiragana = false)
        {
            InitializeComponent();

            var pos = this.PointToScreen(lbl_kanji.Location);
            pos = pictureBox1.PointToClient(pos);
            lbl_kanji.Parent = pictureBox1;
            lbl_kanji.Location = pos;
            lbl_kanji.BackColor = Color.Transparent;

            ReverseCard = reverseCard;
            HideHiragana = hideHiragana;

            currentCard = 0;

            cardToolTip.SetToolTip(lbl_kanji, "");
            cardToolTip.ShowAlways = true;

            cards = new List<Card>(SharedResources.CurrentDeck.Cards);
            CardIndexStart = start;
            CardIndexEnd = end;

            if (studyOption == StudyOption.AMOUNT)
            {
                List<Card> copiedList = new List<Card>(cards);
                int studyAmount = amount;

                if (CardIndexStart > 0 && CardIndexEnd > 0) // Range specified
                {
                    cards = new List<Card>();

                    for (int i = 0; i < copiedList.Count; i++)
                    {
                        if (copiedList[i].ID >= CardIndexStart && copiedList[i].ID <= CardIndexEnd)
                        {
                            cards.Add(copiedList[i]);
                        }
                    }

                    copiedList = new List<Card>(cards); // Re-copy list based on new range
                    copiedList.Shuffle();
                }

                if (studyAmount > cards.Count())
                {
                    studyAmount = cards.Count();
                }

                cards = new List<Card>();

                for (int i = 0; i < studyAmount; i++)
                {
                    cards.Add(copiedList[i]);
                }
            }

            cards.Shuffle();

            btn_next.Text = "Reveal";
            btn_fail.Enabled = false;
            lbl_card_id.Visible = false;

            if (ReverseCard)
            {
                lbl_kanji.Text = HideHiragana ? RemoveJpChars(cards[currentCard].BackText).Item1 : cards[currentCard].BackText;
            }
            else
            {
                lbl_kanji.Text = cards[currentCard].FrontText;
                lbl_card_id.Text = "Card: " + cards[currentCard].ID;
            }

            SetCardFont(true);
            SetCardProgressText();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            ProgressToNextAction();
        }

        private void btn_fail_Click(object sender, EventArgs e)
        {
            repeatCards.Add(cards[currentCard]);
            ProgressToNextAction();
        }

        private void ProgressToNextAction()
        {
            if (CurrentStudyMode == StudyMode.FRONT)
            {
                btn_next.Text = "OK";
                btn_fail.Enabled = true;
                CurrentStudyMode = StudyMode.BACK;

                if (ReverseCard)
                {
                    lbl_kanji.Text = cards[currentCard].FrontText;
                    cardToolTip.SetToolTip(lbl_kanji, RemoveJpChars(cards[currentCard].BackText).Item2);
                }
                else
                {
                    lbl_kanji.Text = cards[currentCard].BackText;
                }

                SetCardFont(false);
                lbl_card_id.Visible = true;
            }
            else if (CurrentStudyMode == StudyMode.BACK)
            {
                btn_next.Text = "Reveal";
                btn_fail.Enabled = false;
                lbl_card_id.Visible = false;
                CurrentStudyMode = StudyMode.FRONT;
                currentCard++;

                // Arrived at end of list, check if any cards left
                if (currentCard >= cards.Count)
                {
                    if (repeatCards.Count > 0)
                    {
                        int cardCount = cards.Count;
                        int repeatCardCount = repeatCards.Count;
                        int correctCardCount = cards.Count - repeatCards.Count;
                        MessageBox.Show(String.Format("Correct: {0}\nMissed: {1}\nTotal Score {2}%", correctCardCount, repeatCardCount, Math.Round(correctCardCount * 100.0 / cardCount, 0)));

                        cards = new List<Card>(repeatCards);
                        repeatCards.Clear();

                        if (ShuffleDeck)
                        {
                            cards.Shuffle();
                        }

                        currentCard = 0;
                        lbl_card_id.Text = "Card: " + cards[currentCard].ID;

                        if (ReverseCard)
                        {
                            cardToolTip.SetToolTip(lbl_kanji, "");

                            if (HideHiragana)
                            {
                                var removeReturnVal = RemoveJpChars(cards[currentCard].BackText);
                                lbl_kanji.Text = removeReturnVal.Item1;
                            }
                            else
                            {
                                lbl_kanji.Text = cards[currentCard].BackText;
                            }
                        }
                        else
                        {
                            lbl_kanji.Text = cards[currentCard].FrontText;
                        }

                        SetCardFont(true);
                        SetCardProgressText();
                    }
                    else
                    {
                        MessageBox.Show("You did it!!");
                        this.Close();
                    }
                }
                else
                {
                    lbl_card_id.Text = "Card: " + cards[currentCard].ID;

                    if (ReverseCard)
                    {
                        cardToolTip.SetToolTip(lbl_kanji, "");

                        if (HideHiragana)
                        {
                            var removeReturnVal = RemoveJpChars(cards[currentCard].BackText);
                            lbl_kanji.Text = removeReturnVal.Item1;
                        }
                        else
                        {
                            lbl_kanji.Text = cards[currentCard].BackText;
                        }
                    }
                    else
                    {
                        lbl_kanji.Text = cards[currentCard].FrontText;
                    }
                    
                    SetCardFont(true);
                    SetCardProgressText();
                }
            }
        }

        private void SetCardFont(bool front)
        {
            if (ReverseCard)
            {
                lbl_kanji.Font = front ? new Font("Yu Gothic UI", 30, FontStyle.Regular) : new Font("Yu Gothic UI", 72, FontStyle.Regular);
            }
            else
            {
                lbl_kanji.Font = front ? new Font("Yu Gothic UI", 72, FontStyle.Regular) : new Font("Yu Gothic UI", 30, FontStyle.Regular);
            }
        }

        private void SetCardProgressText()
        {
            lbl_card_progress.Text = (currentCard + 1) + " / " + cards.Count;
        }

        private String RemoveHiraganaFromText(string text)
        {
            return text.Replace("", "");
        }

        private Tuple<string, string> RemoveJpChars(string text)
        {
            // Regex pattern for Japanese characters
            string jpTextRegEx = @"[\u3040-\u30FF\u4E00-\u9FFF\uFF00-\uFFEF]+";
            return new Tuple<string, string>(Regex.Replace(text, jpTextRegEx, ""), Regex.Match(text, jpTextRegEx).Value);
        }
    }
}
