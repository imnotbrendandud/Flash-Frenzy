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
        private string dirPath;

        public Deck(string in_Name, string dir) 
        {
            cards = new List<Card>();
            name = in_Name;
            dirPath = dir;
        }

        public string GetName()
        {
            return this.name;
        }
        
        public string GetDirPath()
        {
            return this.dirPath;
        }
    }
}
