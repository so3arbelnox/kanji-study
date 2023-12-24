using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiStudy.DataModels
{
    public class KanjiCompound
    {
        public KanjiCompound(String kanji, String hiragana, String definition) 
        {
            this.Kanji = kanji;
            this.Hiragana = hiragana;
            this.Definition = definition;
        }

        public String Kanji { get; set; } = String.Empty;
        public String Hiragana { get; set; } = String.Empty;
        public String Definition { get; set; } = String.Empty;
    }
}
