namespace FlashFrenzy
{
    public partial class Import : Form
    {
        private DirectoryInfo home;
        public Import(DirectoryInfo dir)
        {
            InitializeComponent();
            home = dir;
            this.FormClosing += (sender, e) =>
            {
                // Check if the form is closing by user action (X button)
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    //Reopen SelectDeck Form
                    Home.instance.Show();
                }
            };
        }
        //Confirm Button
        private void button1_Click(object sender, EventArgs e)
        {
            string deckName = textBox1.Text;
            //Ensures there is a name typed in the text box.
            if (textBox1.Text.Length > 0)
            {
                Deck newDeck = null;
                //User selects the Terms file they want to import/copy.
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Txt Files Only | *.txt;";
                    ofd.Title = "Choose the Terms.txt file of the deck you're importing.";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Directory.CreateDirectory(Path.Combine(home.FullName, deckName));
                        newDeck = new(deckName, Path.Combine(home.FullName, deckName));
                        string[] lines = File.ReadAllLines(ofd.FileName);
                        string[] values;
                        for (int i = 0; i < lines.Length; i++)
                        {
                            Card newCard = new Card(newDeck);
                            values = lines[i].ToString().Split('&');
                            newCard.Word = values[0].Trim();
                            newCard.Definition = values[1].Trim();
                            newCard.Mastery = "5";
                            newDeck.cards.Add(newCard);
                            this.Close();
                        }
                    }
                }
                //In case the user cancels the file dialog.
                if (newDeck != null)
                {
                    Home.instance.addDeck(newDeck);
                    Stream file;
                    StreamWriter fileWriter = null;
                    try
                    {
                        file = File.Create(Path.Combine(newDeck.GetDirPath(), "Mastery.txt"));
                        fileWriter = new(file);
                        string sLine = "";
                        for (int i = 0; i < newDeck.cards.Count; i++)
                        {
                            Card card = newDeck.cards[i];
                            sLine = card.Mastery + "&";
                            fileWriter.WriteLine(sLine);
                        }
                        fileWriter.Close();
                        file = File.Create(Path.Combine(newDeck.GetDirPath(), "Terms.txt"));
                        fileWriter = new(file);
                        for (int i = 0; i < newDeck.cards.Count; i++)
                        {
                            Card card = newDeck.cards[i];
                            sLine = card.Word + "&" + card.Definition + "&";
                            fileWriter.WriteLine(sLine);
                        }
                        fileWriter.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error with saving.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fileWriter != null)
                        {
                            fileWriter.Close();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
