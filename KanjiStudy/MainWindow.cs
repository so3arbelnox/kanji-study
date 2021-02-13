using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace KanjiApp
{
    public partial class MainWindow : Form
    {
        private enum FontSizes
        {
            Small = 16,
            Medium = 20,
            Large = 26
        }

        public MainWindow()
        {
            InitializeComponent();

            if (Properties.Settings.Default["LOADED_DECK"] != null && !String.IsNullOrEmpty(Properties.Settings.Default["LOADED_DECK"].ToString()))
            {
                if (!LoadDeck(Properties.Settings.Default["LOADED_DECK"].ToString()))
                {
                    Properties.Settings.Default["LOADED_DECK"] = "";
                }
            }

            lw_kanji.MouseClick += Lw_kanji_MouseClick;
            contextMenuStrip1.Items[0].Click += Edit_Click;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (lw_kanji.SelectedItems != null && lw_kanji.SelectedItems.Count > 0)
            {
                frm_addeditcard addeditCardForm = new frm_addeditcard();
                addeditCardForm.MainWindowRef = this;
                addeditCardForm.SetCurrentMode(frm_addeditcard.CardManagementMode.Edit, SharedResources.CurrentDeck.Cards[(Int32)lw_kanji.SelectedItems[0].Tag]);
                addeditCardForm.ShowDialog();
            }
        }

        private void Lw_kanji_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lw_kanji.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
        public bool LoadDeck(String filename)
        {
            StreamReader kanjiFile = new StreamReader(filename);

            try
            {
                List<Card> cards = new List<Card>();

                lw_kanji.Clear();
                String deckTitle = "";
                String line;

                int lineNum = 0;

                while ((line = kanjiFile.ReadLine()) != null)
                {
                    if (line.StartsWith("Title="))
                    {
                        deckTitle = line.Substring(line.IndexOf('=') + 1);
                        lbl_deck_title.Text = deckTitle;
                        continue;
                    }

                    if (line.StartsWith("----")) { continue; }

                    String[] cardText = line.Split('|');
                    ListViewItem itemToAdd;

                    if (cardText.Length == 2)
                    {
                        itemToAdd = new ListViewItem(cardText[0]);
                        itemToAdd.Tag = cards.Count; // Set tag to index, should be current count before add
                        itemToAdd.ToolTipText = cardText[1];
                        lw_kanji.Items.Add(itemToAdd);
                        cards.Add(new Card(0, cardText[0], cardText[1]));
                    }
                    else if (cardText.Length == 3)
                    {
                        itemToAdd = new ListViewItem(cardText[1]);
                        itemToAdd.Tag = cards.Count; // Set tag to index, should be current count before add
                        itemToAdd.ToolTipText = cardText[2];
                        lw_kanji.Items.Add(itemToAdd);
                        cards.Add(new Card(Int32.Parse(cardText[0]), cardText[1], cardText[2]));
                    }

                    lineNum++;
                }

                Deck newDeck = new Deck(deckTitle, cards);
                newDeck.FileName = filename;

                // Check duplicate (testing)
                List<String> cardFrontTextList = new List<String>();
                
                /*
                foreach (Card card in newDeck.Cards)
                {
                    if (cardFrontTextList.Contains(card.FrontText))
                    {
                        Console.WriteLine("ID: " + card.ID + " Found duplicate: " + card.FrontText);
                    }
                    else
                    {
                        cardFrontTextList.Add(card.FrontText);
                    }
                }
                */

                SharedResources.CurrentDeck = newDeck;
                lbl_entry_count.Text = "Entries: " + SharedResources.CurrentDeck.Cards.Count;
                lbl_card_count.Text = "Cards: " + getUniqueCardCount().ToString();

                Properties.Settings.Default["LOADED_DECK"] = filename;
                Properties.Settings.Default.Save();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load deck: " + ex.Message);
                return false;
            }
            finally
            {
                kanjiFile.Close();
            }
        }

        private int getUniqueCardCount()
        {
            List<Int32> cardIds = new List<Int32>();
            int uniqueCardCount = 0;

            foreach (Card card in SharedResources.CurrentDeck.Cards)
            {
                if (!cardIds.Contains(card.ID))
                {
                    uniqueCardCount++;
                    cardIds.Add(card.ID);
                }
            }

            return uniqueCardCount;
        }

        private void btn_load_deck_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select Anki export text file";
            fileDialog.Filter = "Text files (*.txt)|*.txt";
            fileDialog.CheckFileExists = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadDeck(fileDialog.FileName);
            }
        }

        private void btn_add_card_Click(object sender, EventArgs e)
        {
            if (SharedResources.CurrentDeck != null)
            {
                frm_addeditcard addeditCardForm = new frm_addeditcard();
                addeditCardForm.MainWindowRef = this;
                addeditCardForm.SetCurrentMode(frm_addeditcard.CardManagementMode.Add, null);
                addeditCardForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is currently no deck loaded. You must load a deck before adding a card.", "Error");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            cbSize.SelectedIndex = 0;
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSize.SelectedIndex)
            {
                case 0:
                    lw_kanji.Font = new Font("Yu Gothic UI", (float)FontSizes.Small, FontStyle.Regular);
                    break;
                case 1:
                    lw_kanji.Font = new Font("Yu Gothic UI", (float)FontSizes.Medium, FontStyle.Regular);
                    break;
                case 2:
                    lw_kanji.Font = new Font("Yu Gothic UI", (float)FontSizes.Large, FontStyle.Bold);
                    break;
                default:
                    break;
            }
        }

        private void btn_study_cards_Click(object sender, EventArgs e)
        {
            frm_study_options so = new frm_study_options();
            so.ShowDialog();
        }
    }
}
