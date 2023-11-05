using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Timers;
using static FlashFrenzy.Program;

namespace FlashFrenzy
{
    public partial class Card : Form
    {
        //More cards will be added here, but will be uploaded through a local file (which will be read in).
        public string Word { get; set; }
        public string Definition { get; set; }
        public string Mastery { get; set; } //Ranges from 1 to 10 (1 being the least amount of knowledge).

        // Customization properties
        public Color BackgroundColor { get; set; } = Color.White; // Default color
        public Font CardFont { get; set; } = new Font("Arial", 12); // Default font
        public Color TextColor { get; set; } = Color.Black; // Default text color


        public Card()
        {
            InitializeComponent(); //Initializes the card.
            this.Text = "Card"; //Sets the title of the form to "Card".
            button3.Hide(); button4.Hide(); button5.Hide(); //Hides definition side buttons.
            button1.Font = new Font(button1.Font.FontFamily, 32); //Edits the font of the word side of a card.
            button2.Font = new Font(button1.Font.FontFamily, 24); //Edits the font of the definition side of a card.
            button1.Text = this.Word;  //Displays the word grabbed from class CardInfo.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Show(); button3.Show(); button4.Show(); button5.Show(); //Shows definition side buttons.
            button1.Hide(); //Hides word side button.
            button2.Text = this.Definition; //Displays the definition grabbed from class CardInfo.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); //Hides definition side buttons.
            button1.Show(); //Shows word side button.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //To be implemented in the next sprint.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //To be implemented in the next sprint.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //To be implemented in the next sprint.
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) //This is for the dark mode which is a part of the card customization.
            {
                this.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //THIS WILL BE CHANGED!!! AS OF NOW, IT REDIRECTS TO DEFAULT DECK.
            //SelectDeck nextForm = new SelectDeck();
            //this.Hide();
            //nextForm.Show();
        }
    }
}