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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            this.Text = "Home";

            listBox1.Items.Add("1");
            listBox1.Items.Add("2");
            listBox1.Items.Add("3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectDeck selectDeck = new SelectDeck();
            this.Hide();
            selectDeck.Show();
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
    }
}
