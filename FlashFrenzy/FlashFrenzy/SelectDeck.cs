using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFrenzy
{
    public partial class SelectDeck : Form
    {
        public SelectDeck()
        {
            //To be implemented in the next sprint.
            InitializeComponent();
            this.Text = "Select Deck";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //THIS WILL BE CHANGED!!! AS OF NOW, IT REDIRECTS TO DEFAULT DECK.
            Card nextForm = new Card();
            this.Hide();
            nextForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home nextForm = new Home();
            this.Hide();
            nextForm.Show();
        }
    }
}
