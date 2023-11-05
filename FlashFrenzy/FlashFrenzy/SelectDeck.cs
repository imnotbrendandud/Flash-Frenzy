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
        // The current deck selected
        public static Deck? currentDeck;

        // Number of cards in the deck
        public int numCards = 0;

        public SelectDeck(Deck selectedDeck)
        {
            //To be implemented in the next sprint.
            InitializeComponent();
            label2.Text = selectedDeck.GetName();
            this.Text = selectedDeck.GetName();

            // Load each card into the data grid view
            foreach (Card card in selectedDeck.cards)
            {
                dataGridView1.Rows.Add(numCards++, card.Word, card.Definition, card.Mastery);
            }


            currentDeck = selectedDeck;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //THIS WILL BE CHANGED!!! AS OF NOW, IT REDIRECTS TO DEFAULT DECK.
            this.Hide();
            currentDeck.cards[0].Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home nextForm = new Home();
            this.Hide();
            nextForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        // Exporting
        private void button7_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (.txt)|.txt|All files (.)|.";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    System.IO.StreamWriter file = new System.IO.StreamWriter(myStream);
                    try
                    {
                        string sLine = "";

                        //This for loop loops through each row in the table
                        for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                        {
                            //This for loop loops through each column, and the row number
                            //is passed from the for loop above.
                            for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                            {
                                sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                                if (c != dataGridView1.Columns.Count - 1)
                                {
                                    //A comma is added as a text delimiter in order
                                    //to separate each field in the text file.
                                    //You can choose another character as a delimiter.
                                    sLine = sLine + "&";
                                }

                            }
                            //The exported text is written to the text file, one line at a time.
                            file.WriteLine(sLine);
                            sLine = "";
                        }

                        file.Close();
                        System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Exception err)
                    {
                        System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        file.Close();
                    }
                    myStream.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Importing
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Filter = "Txt Files Only | *.txt;";
                ofd.Title = "Choose the file";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Display file name for user!!
                    //FileName_LBL.Text = ofd.FileName;
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    string[] values;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Card newCard = new Card();
                        values = lines[i].ToString().Split('&');
                        string[] row = new string[values.Length];


                        for (int j = 1; j < values.Length; j++)
                        {
                            row[j] = values[j].Trim();
                            newCard.Word = row[1];
                            newCard.Definition = row[2];
                            newCard.Mastery = row[3];
                        }

                        currentDeck.cards.Add(newCard);
                        dataGridView1.Rows.Add(numCards++, newCard.Word, newCard.Definition, newCard.Mastery);
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCard nextForm = new AddCard(currentDeck);
            nextForm.Show();
            this.Hide();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["RowNum"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Mastery"].Value = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if any cells are currently selected in the DataGridView.
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the index of the selected row.
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Get the Card object from the currentDeck's cards list at the selected row index.
                // This assumes that the order of rows in the DataGridView matches the order of the cards list.
                Card selectedCard = currentDeck.cards[selectedRowIndex];

                // Now we can pass this Card object to the CardCustomize form.
                CardCustomize customizeForm = new CardCustomize(selectedCard);

                // Show the CardCustomize form as a dialog.
                customizeForm.ShowDialog(); // Use ShowDialog to make it modal if needed.
            }
            else
            {
                MessageBox.Show("Please select a card to customize.");
            }
        }
    }
}
