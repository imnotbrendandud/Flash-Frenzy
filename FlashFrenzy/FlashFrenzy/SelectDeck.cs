using System.IO;

namespace FlashFrenzy
{
    public partial class SelectDeck : Form
    {
        // The current deck selected
        public static Deck? currentDeck;

        // Number of cards in the deck
        public int numCards = 0;

        /* Prevents the CellChange event from firing when the program makes changes to the DataGrid.
         * Set false before performing changes to the dataGrid through code.
         * Set true when finished with changes.
         * Only applies in this form.
         */
        private bool usrChanges = false;

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
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(GridCellChanged);
            
            // Subscribe to the FormClosed event to handle application exit
            this.FormClosed += SelectDeck_FormClosed;
        }
        
        // Event handler for FormClosed event
        private void SelectDeck_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Call Application.Exit() to close the entire application
            Application.Exit();
        }
        //Study
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (currentDeck.cards.Count > 0)
            {
                Card nextForm = new Card(currentDeck);
                this.Hide();
                nextForm.ShowDialog();
                Autosave();
            }
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

                    StreamWriter file = new StreamWriter(myStream);
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
                        MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        file.Close();
                    }
                    myStream.Close();
                }
            }
        }

        // Importing
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            usrChanges = false;
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
                        Card newCard = new Card(currentDeck);
                        values = lines[i].ToString().Split('&');
                        string[] row = new string[values.Length];


                        for (int j = 0; j < values.Length; j++)
                        {
                            row[j] = values[j].Trim();
                        }

                        newCard.Word = row[0];
                        newCard.Definition = row[1];
                        currentDeck.cards.Add(newCard);
                        dataGridView1.Rows.Add(numCards++, newCard.Word, newCard.Definition, newCard.Mastery);
                    }
                }
            }
            usrChanges = true;
        }
        //Handles the actual saving process, including opening and closing the file.
        private void Save(StreamWriter file, bool mast)
        {
            try
            {
                string sLine = "";
                if (mast)
                {
                    for (int i = 0; i < currentDeck.cards.Count; i++)
                    {
                        Card card = currentDeck.cards[i];
                        sLine = card.Mastery + "&";
                        file.WriteLine(sLine);
                    }
                    file.Close();
                }
                else
                {
                    for (int i = 0; i < currentDeck.cards.Count; i++)
                    {
                        Card card = currentDeck.cards[i];
                        sLine = card.Word + "&" + card.Definition + "&";
                        file.WriteLine(sLine);
                    }
                    file.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error with saving.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        //AutoSave function used for add, edit, and delete buttons.
        private void Autosave()
        {
            Stream auto = File.Create(Path.Combine(currentDeck.GetDirPath(), "Terms.txt"));
            StreamWriter autoWriter = new(auto);
            Save(autoWriter, false);
            auto = File.Create(Path.Combine(currentDeck.GetDirPath(), "Mastery.txt"));
            autoWriter = new(auto);
            Save(autoWriter, true);

        }

        private void GridCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (usrChanges)
            {
                string dirtyCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (e.ColumnIndex == 1)
                {
                    currentDeck.cards[e.RowIndex].Word = dirtyCell;
                }
                else if (e.ColumnIndex == 2)
                {
                    currentDeck.cards[e.RowIndex].Definition = dirtyCell;
                }
            }
        }

        //Save edits made to the datagrid.
        private void button3_Click(object sender, EventArgs e)
        {
            Autosave();
        }

        //Add button
        private void button4_Click(object sender, EventArgs e)
        {
            AddCard nextForm = new(currentDeck);
            this.Hide();
            nextForm.ShowDialog();
            Autosave();
        }

        //Delete button
        private void button5_Click(object sender, EventArgs e)
        {
            if (currentDeck.cards.Count > 0)
            {
                int selectedCells = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCells > 0)
                {
                    for (int i = 0; i < selectedCells; i++)
                    {
                        DataGridViewCell cell = dataGridView1.SelectedCells[i];
                        currentDeck.cards.RemoveAt(cell.RowIndex);
                        dataGridView1.Rows.Remove(cell.OwningRow);
                        selectedCells = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                        Autosave();
                    }
                    label4.Visible = false;
                }
                else
                {
                    label4.Visible = true;
                }
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            usrChanges = false;
            this.dataGridView1.Rows[e.RowIndex].Cells["RowNum"].Value = (e.RowIndex + 1).ToString();
            usrChanges = true;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            usrChanges = false;
            e.Row.Cells["Mastery"].Value = 5;
            usrChanges = true;
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
