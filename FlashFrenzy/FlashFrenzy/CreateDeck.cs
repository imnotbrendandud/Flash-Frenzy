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
    public partial class CreateDeck : Form
    {

        public CreateDeck()
        {
            InitializeComponent();
        }



        private void btn_cD_confirm_Click(object sender, EventArgs e)
        {
            Deck newDeck = new Deck(txtBox_cD_name.Text);
            this.Hide();
            Home.instance.addDeck(newDeck);
            Home.instance.Show();
        }

        private void btn_cD_back_Click(object sender, EventArgs e)
        {
           
        }
    }
}
