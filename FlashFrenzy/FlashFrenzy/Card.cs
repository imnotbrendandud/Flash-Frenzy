using System.Collections;
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

        Deck thisDeck;
        int numberOfCards = 0;

        Queue<int> startingMastery = new Queue<int>();
        Queue<int> updatedMastery = new Queue<int>();
        Queue<int> originIndex = new Queue<int>();
        Queue<Card> cards = new Queue<Card>();

        int startingMasteryInt = 0;
        int updatedMasteryInt = 0;
        int originIndexInt = 0;
        Card currentCard;

        Queue<int> finalMastery = new Queue<int>();
        Queue<int> finalIndex = new Queue<int>();

        public Card(Deck selectedDeck)
        {
            InitializeComponent(); //Initializes the card.
            thisDeck = selectedDeck;
            button1.Hide(); button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); //Hides definition side buttons.
            button1.Font = new Font(button1.Font.FontFamily, 32); //Edits the font of the word side of a card.
            button2.Font = new Font(button1.Font.FontFamily, 24); //Edits the font of the definition side of a card.
            button7.Font = new Font(button1.Font.FontFamily, 40); //Edits the font of the start card.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Show(); button3.Show(); button4.Show(); button5.Show(); //Shows definition side buttons.
            button1.Hide(); //Hides word side button.
            button2.Text = currentCard.Definition; //Displays the definition grabbed from class CardInfo.
            button4.Text = updatedMasteryInt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide(); //Hides definition side buttons.
            button1.Show(); //Shows word side button.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            originIndex.Enqueue(originIndexInt);
            if (startingMasteryInt > 0)
            {
                updatedMasteryInt--;
                startingMasteryInt--;
                startingMastery.Enqueue(startingMasteryInt);
                updatedMastery.Enqueue(updatedMasteryInt);
            } else
            {
                updatedMastery.Enqueue(updatedMasteryInt);
                startingMastery.Enqueue(startingMasteryInt);
            }
            cards.Enqueue(currentCard);
            currentCard = cards.Dequeue();
            startingMasteryInt = startingMastery.Dequeue();
            updatedMasteryInt = updatedMastery.Dequeue();
            originIndexInt = originIndex.Dequeue();

            button1.Text = currentCard.Word;
            button1.Show(); button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startingMastery.Enqueue(startingMasteryInt);
            updatedMastery.Enqueue(updatedMasteryInt);
            originIndex.Enqueue(originIndexInt);
            cards.Enqueue(currentCard);

            currentCard = cards.Dequeue();
            startingMasteryInt = startingMastery.Dequeue();
            updatedMasteryInt = updatedMastery.Dequeue();
            originIndexInt = originIndex.Dequeue();

            button1.Text = currentCard.Word;
            button1.Show(); button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (updatedMasteryInt == 10)
            {
                updatedMasteryInt = 10;
                finalMastery.Enqueue(updatedMasteryInt);
                finalIndex.Enqueue(originIndexInt);
            } else if (updatedMasteryInt > startingMasteryInt)
            {
                updatedMasteryInt++;
                finalMastery.Enqueue(updatedMasteryInt);
                finalIndex.Enqueue(originIndexInt);
            } else
            {
                updatedMasteryInt++;
                startingMastery.Enqueue(startingMasteryInt);
                updatedMastery.Enqueue(updatedMasteryInt);
                originIndex.Enqueue(originIndexInt);
                cards.Enqueue(currentCard);
            }

            //Checks to see if session should be ended.
            if (cards.Count <= 0)
            {
                for (int i = 0; i < finalMastery.Count; i++)
                {
                    int masteryTransfer = finalMastery.Dequeue();
                    string transferredMastery = masteryTransfer.ToString();
                    thisDeck.cards[finalIndex.Dequeue()].Mastery = transferredMastery;
                }
                SelectDeck nextForm = new SelectDeck(thisDeck);
                nextForm.Show();
                this.Close();
            } else
            {
                currentCard = cards.Dequeue();
                startingMasteryInt = startingMastery.Dequeue();
                updatedMasteryInt = updatedMastery.Dequeue();
                originIndexInt = originIndex.Dequeue();

                button1.Text = currentCard.Word;
                button1.Show(); button2.Hide(); button3.Hide(); button4.Hide(); button5.Hide();
            }
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
            SelectDeck nextForm = new SelectDeck(thisDeck);
            this.Hide();
            nextForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numberOfCards = thisDeck.cards.Count;

            //Populating startingMastery and updatedMastery
            for (int i = 0; i < numberOfCards; i++)
            {
                string joe = thisDeck.cards[i].Mastery;
                int biden = Int32.Parse(joe);
                startingMastery.Enqueue(biden);
                updatedMastery.Enqueue(biden);
                originIndex.Enqueue(i);
                cards.Enqueue(thisDeck.cards[i]);
            }

            button7.Hide();
            button1.Show();

            currentCard = cards.Dequeue();
            startingMasteryInt = startingMastery.Dequeue();
            updatedMasteryInt = updatedMastery.Dequeue();
            originIndexInt = originIndex.Dequeue();

            button1.Text = currentCard.Word;
        }
    }
}