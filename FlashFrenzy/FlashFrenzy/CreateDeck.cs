using Microsoft.Office.Interop.Excel;
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
        }



        private void btn_cD_confirm_Click(object sender, EventArgs e)
        {
            Deck newDeck = new Deck(txtBox_cD_name.Text);

            string foldername = txtBox_cD_name.Text;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirPath = Path.Combine(fbd.SelectedPath, foldername);
                    if (!(File.Exists(dirPath)))
                    {
                        System.IO.Directory.CreateDirectory(dirPath);
                        File.Create(Path.Combine(dirPath, "Terms.txt"));
                        File.Create(Path.Combine(dirPath, "Mastery.txt"));
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
           
        }
    }
}
