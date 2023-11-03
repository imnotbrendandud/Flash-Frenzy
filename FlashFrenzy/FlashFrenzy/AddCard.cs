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

        //public static AddCard addCardInstance = new AddCard();
        public static string addedTerm;
        public static string addedDefinition;

        public AddCard()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            addedTerm = addCardTerm.Text;
            addedDefinition = addCardDefinition.Text;
            SelectDeck nextForm = new SelectDeck();
            this.Hide();
            nextForm.Show();
        }
    }
}
