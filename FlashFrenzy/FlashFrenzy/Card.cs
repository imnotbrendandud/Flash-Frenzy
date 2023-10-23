using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using static FlashFrenzy.Program;

namespace FlashFrenzy
{
    public partial class Card : Form
    {
        CardInfo card1 = new CardInfo("2 + 2", "4");
        public Card()
        {
            InitializeComponent();
            this.Text = "Card";
            button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); //Hides definition side buttons.
            button1.Font = new Font(button1.Font.FontFamily, 32);
            button2.Font = new Font(button1.Font.FontFamily, 24);
            button1.Text = card1.word;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Show(); button3.Show(); button4.Show(); button5.Show(); //Shows definition side buttons.
            button1.Hide(); //Hides word side button.
            button2.Text = card1.definition;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); //Hides definition side buttons.
            button1.Show(); //Shows word side button.
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}