using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFrenzy
{
    public class Deck
    {
        public List<Card> cards;
        private string name;

        public Deck(string in_Name) 
        {
            cards = new List<Card>();
            name = in_Name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
