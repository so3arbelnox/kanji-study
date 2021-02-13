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

namespace KanjiApp
{
    public partial class frm_addeditcard : Form
    {
        public MainWindow MainWindowRef { get; set; }

        public enum CardManagementMode
        {
            Add = 0,
            Edit = 1
        }

        private CardManagementMode currentMode;
        private Card currentCard; // Applicable for edit mode only

        public frm_addeditcard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public void SetCurrentMode(CardManagementMode mode, Card card)
        {
            currentMode = mode;

            if (currentMode == CardManagementMode.Add)
            {
                this.Text = "Deck Management - Add";
                btn_add_card.Text = "Add Card";
            }
            else if (currentMode == CardManagementMode.Edit)
            {                
                this.Text = "Deck Management - Edit";
                btn_add_card.Text = "Edit Card";
                currentCard = card;
                txtCardFront.Text = currentCard.FrontText;
                txtCardBack.Text = currentCard.BackText;
                nm_id.Value = currentCard.ID;
            }
        }

        public void EditDeck()
        {
            var cardSearchText = currentCard.ID.ToString() + "|" + currentCard.FrontText + "|" + currentCard.BackText;
            var newCardText = (int)nm_id.Value + "|" + txtCardFront.Text + "|" + txtCardBack.Text;

            var fileText = File.ReadAllText(SharedResources.CurrentDeck.FileName);
            fileText = fileText.Replace(cardSearchText, newCardText);
            File.WriteAllText(SharedResources.CurrentDeck.FileName, fileText);
            MainWindowRef.LoadDeck(SharedResources.CurrentDeck.FileName);
        }

        private void btn_add_card_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCardFront.Text))
            {
                MessageBox.Show("Card front text cannot be empty!", "Error");
            }
            else if (String.IsNullOrWhiteSpace(txtCardBack.Text))
            {
                MessageBox.Show("Card back text cannot be empty!", "Error");
            }
            else
            {
                if (currentMode == CardManagementMode.Add)
                {
                    try
                    {
                        int ID = (int)nm_id.Value;
                        Card card = new Card(ID, txtCardFront.Text, txtCardBack.Text);
                        //SharedResources.CurrentDeck.AddCard(new Card(txtCardFront.Text, txtCardBack.Text));
                        txtCardFront.Clear();
                        txtCardBack.Clear();

                        StreamWriter kanjiFile = new StreamWriter(SharedResources.CurrentDeck.FileName, true);
                        kanjiFile.Write("\n" + ID.ToString() + "|" + card.FrontText + "|" + card.BackText);
                        kanjiFile.Close();

                        MainWindowRef.LoadDeck(SharedResources.CurrentDeck.FileName);

                        //MessageBox.Show("Successfully added card to deck: " + SharedResources.CurrentDeck.Title, "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not add card to deck. Error: " + ex.Message, "Error");
                    }
                }
                else if (currentMode == CardManagementMode.Edit)
                {
                    try
                    {
                        EditDeck();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not edit card. Error: " + ex.Message, "Error");
                    }
                }
            }
        }
    }
}
