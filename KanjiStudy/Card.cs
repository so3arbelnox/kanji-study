using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiApp
{
    public class Card
    {
        public int ID { get; } // The ID of the card this word belongs to
        public String FrontText { get; set; }
        public String BackText { get; set; }

        public Card(Int32 id, String frontText, String backText)
        {
            this.ID = id;

            this.FrontText = frontText;
            this.BackText = backText;
        }
    }
}
