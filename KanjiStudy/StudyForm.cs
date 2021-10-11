﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiApp
{
    public partial class StudyForm : Form
    {
        private int currentCard = 0;

        public enum StudyMode
        {
            FRONT = 0,
            BACK = 1
        }

        public enum StudyOption
        {
            RANGE = 0,
            AMOUNT = 1,
            ALL = 2
        }

        public StudyMode CurrentStudyMode { get; set; }
        public bool ShuffleDeck { get; set; }
        public bool UseRange { get; set; }

        // If range selected
        public int CardIndexStart { get; set; }
        public int CardIndexEnd { get; set; }

        List<Card> repeatCards = new List<Card>();
        List<Card> cards; // Cloned list of cards
        
        public StudyForm(StudyOption studyOption, int start, int end, int amount)
        {
            InitializeComponent();

            var pos = this.PointToScreen(lbl_kanji.Location);
            pos = pictureBox1.PointToClient(pos);
            lbl_kanji.Parent = pictureBox1;
            lbl_kanji.Location = pos;
            lbl_kanji.BackColor = Color.Transparent;

            CurrentStudyMode = StudyMode.FRONT;
            currentCard = 0;

            cards = new List<Card>(SharedResources.CurrentDeck.Cards);
            CardIndexStart = start;
            CardIndexEnd = end;

            if (studyOption == StudyOption.RANGE)
            {
                List<Card> copiedList = new List<Card>(cards);
                cards = new List<Card>();

                for (int i = 0; i < copiedList.Count; i++)
                {
                    if (copiedList[i].ID >= CardIndexStart && copiedList[i].ID <= CardIndexEnd)
                    {
                        cards.Add(copiedList[i]);
                    }
                }
            }
            else if (studyOption == StudyOption.AMOUNT)
            {
                int studyAmount = amount;
                if (studyAmount > cards.Count()) { studyAmount = cards.Count(); }

                cards.Shuffle();

                List<Card> copiedList = new List<Card>(cards);
                cards = new List<Card>();

                for (int i = 0; i < studyAmount; i++)
                {
                    cards.Add(copiedList[i]);
                }
            }

            cards.Shuffle();

            btn_next.Text = "Reveal";
            btn_fail.Enabled = false;

            lbl_kanji.Text = cards[currentCard].FrontText;
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
                lbl_kanji.Text = cards[currentCard].BackText;
                lbl_kanji.Font = new Font("Yu Gothic UI", 30, FontStyle.Regular);
            }
            else if (CurrentStudyMode == StudyMode.BACK)
            {
                btn_next.Text = "Reveal";
                btn_fail.Enabled = false;
                CurrentStudyMode = StudyMode.FRONT;
                currentCard++;

                // Arrived at end of list, check if any cards left
                if (currentCard >= cards.Count)
                {
                    if (repeatCards.Count > 0)
                    {
                        cards = new List<Card>(repeatCards);
                        repeatCards.Clear();

                        if (ShuffleDeck)
                        {
                            cards.Shuffle();
                        }

                        currentCard = 0;
                        lbl_kanji.Text = cards[currentCard].FrontText;
                        lbl_kanji.Font = new Font("Yu Gothic UI", 72, FontStyle.Regular);
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
                    lbl_kanji.Text = cards[currentCard].FrontText;
                    lbl_kanji.Font = new Font("Yu Gothic UI", 72, FontStyle.Regular);
                    SetCardProgressText();
                }
            }
        }

        private void SetCardProgressText()
        {
            lbl_card_progress.Text = (currentCard + 1) + " / " + cards.Count;
        }
    }
}
