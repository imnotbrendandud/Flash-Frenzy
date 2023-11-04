using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFrenzy
{
    public partial class Home : Form
    {
        public static Home instance;

        public static List<Deck> decks;
        public Home()
        {
            InitializeComponent();

            if (instance == null)
            {
                decks = new List<Deck>();
                instance = this;
                this.Text = "Home";
            }
            else
            {
                foreach (Deck deck in decks)
                {
                    listBox1.Items.Add(deck.GetName());
                }
            }
        }

        public Home(Deck newDeck)
        {
            InitializeComponent();

            listBox1.Items.Add(newDeck.GetName());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelectDeck selectDeck;

            if (listBox1.SelectedItem != null)
            {
                foreach (Deck deck in decks)
                {
                    if (!listBox1.GetItemText(listBox1.SelectedItem).Equals(deck.GetName()))
                    {
                        continue;
                    }
                    selectDeck = new SelectDeck(deck);
                    this.Hide();
                    selectDeck.Show();
                }
            }
            /*Security:
             * This is the primary security aspect we implemented after the code was developed.
             * When the user transitions between the home page to the card, the card form is opened, but before, the home form stayed open.
             * So, we made sure to HIDE THE FORM to not allow access to two forms at once (as this could compromise data).
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addDeck(Deck newDeck)
        {
            decks.Add(newDeck);
            listBox1.Items.Add(newDeck.GetName());
        }

        private void btn_h_newDeck_Click_1(object sender, EventArgs e)
        {
            CreateDeck createDeck = new CreateDeck();
            this.Hide();
            createDeck.Show();
        }
    }
}
