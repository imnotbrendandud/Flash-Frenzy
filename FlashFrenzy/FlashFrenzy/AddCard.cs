using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlashFrenzy.Program;
using static System.Windows.Forms.DataFormats;

namespace FlashFrenzy
{
    public partial class AddCard : Form
    {
        Deck deck;
        Card newCard;
        //public static AddCard addCardInstance = new AddCard();
        public static string addedTerm;
        public static string addedDefinition;

        public AddCard(Deck currentDeck)
        {
            InitializeComponent();
            newCard = new Card();
            deck = currentDeck;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            addedTerm = addCardTerm.Text;
            addedDefinition = addCardDefinition.Text;

            newCard.word = addedTerm;
            newCard.definition = addedDefinition;
            newCard.confidence = 5;
            deck.cards.Add(newCard);
            SelectDeck nextForm = new SelectDeck(SelectDeck.currentDeck);
            this.Hide();
            nextForm.Show();
        }

        private void addCardTerm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
