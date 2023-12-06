
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFrenzy
{
    public partial class CreateDeck : Form
    {
        public string dirPath = "";

        public CreateDeck()
        {
            InitializeComponent();
            // Handle the FormClosing event of the CreateDeck form to ensure it exits gracefully
            this.FormClosing += (sender, e) =>
            {
                // Check if the form is closing by user action (X button)
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    // Prevent the default form closing behavior (closing the form)
                    e.Cancel = true;

                    // Perform any cleanup or save operations if needed

                    // Exit the application
                    Application.Exit();
                }
            };
        }



        private void btn_cD_confirm_Click(object sender, EventArgs e)
        {
            string foldername = txtBox_cD_name.Text;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirPath = Path.Combine(fbd.SelectedPath, foldername);
                    if (!(File.Exists(dirPath)))
                    {
                        Directory.CreateDirectory(dirPath);
                        //File.Create(Path.Combine(dirPath, "Terms.txt"));
                        //File.Create(Path.Combine(dirPath, "Mastery.txt"));
                        Deck newDeck = new Deck(txtBox_cD_name.Text, dirPath);
                        Home.instance.addDeck(newDeck);
                    }
                    else if (File.Exists(dirPath)) // This else statement is not working for some reason 
                    {
                        MessageBox.Show("File Path Already Exists", "File Path Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.Hide();
            Home.instance.Show();
            
        }

        private void btn_cD_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.instance.Show();
        }
    }
}
