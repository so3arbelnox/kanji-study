using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiApp
{
    public class Deck
    {
        private static int NEXT_ID = 0;

        public int ID { get; }
        public String Title { get; set; }
        public String FileName { get; set; }
        public List<Card> Cards { get; set; }
               
        public Deck(String title, List<Card> cards)
        {
            this.ID = NEXT_ID;
            NEXT_ID++;

            this.Title = title;
            this.Cards = cards;
        }

        public void AddCard(Card card)
        {
            if (!this.Cards.Contains(card))
            {
                this.Cards.Add(card);
            }
            else
            {
                Console.WriteLine("Cannot add duplicate card to deck.");
            }
        }
    }
}
