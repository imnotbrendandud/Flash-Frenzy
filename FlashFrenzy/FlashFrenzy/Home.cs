﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashFrenzy
{
    public partial class Home : Form
    {
        public static Home instance;
        
        //Home directory path for FlashFrenzy, used here and in imports.
        private static DirectoryInfo homeDir;

        public static List<Deck> decks;
        public Home()
        {
            InitializeComponent();

            if (instance == null)
            {
                decks = new List<Deck>();
                instance = this;
                this.Text = "Home";
                //This long line grabs the user's My Documents folder and combines it with FlashFrenzy to get the path ~\Documents\FlashFrenzy (hopefully).
                //If the path doesn't exist, it creates it.
                homeDir = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Documents/FlashFrenzy"));
                //Grabs all subdirectories in the FlashFrenzy directory.
                DirectoryInfo[] decksDir = homeDir.GetDirectories();
                for (int c = 0; c < decksDir.Length; c++)
                {
                    Deck newDeck = new Deck(decksDir[c].Name, decksDir[c].FullName);
                    string[] lines = new string[0];
                    if (File.Exists(Path.Combine(decksDir[c].FullName, "Terms.txt")))
                    {
                        lines = File.ReadAllLines(Path.Combine(decksDir[c].FullName, "Terms.txt"));
                    }
                    else
                    {
                        File.Create(Path.Combine(decksDir[c].FullName, "Terms.txt"));
                    }
                    string[] masteries = new string[0];
                    if (File.Exists(Path.Combine(decksDir[c].FullName, "Mastery.txt")))
                    {
                        masteries = File.ReadAllLines(Path.Combine(decksDir[c].FullName, "Mastery.txt"));
                    }
                    else
                    {
                        File.Create(Path.Combine(decksDir[c].FullName, "Mastery.txt"));
                    }
                    string[] values;
                    string[] fileMastery;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Card newCard = new Card(newDeck);
                        values = lines[i].ToString().Split('&');
                        fileMastery = masteries[i].ToString().Split('&');
                        newCard.Word = values[0].Trim();
                        newCard.Definition = values[1].Trim();
                        newCard.Mastery = fileMastery[0].Trim();
                        newDeck.cards.Add(newCard);
                    }
                    decks.Add(newDeck);
                    listBox1.Items.Add(decks[c].GetName());
                }
            } 
            else
            {
                foreach (Deck deck in decks)
                {
                    listBox1.Items.Add(deck.GetName());
                }
            }
        }

        public Home(Deck newDeck)
        {
            InitializeComponent();

            listBox1.Items.Add(newDeck.GetName());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelectDeck selectDeck;

            if (listBox1.SelectedItem != null)
            {
                foreach (Deck deck in decks)
                {
                    if (!listBox1.GetItemText(listBox1.SelectedItem).Equals(deck.GetName()))
                    {
                        continue;
                    }
                    selectDeck = new SelectDeck(deck);
                    this.Hide();
                    selectDeck.Show();
                }
            }
            /*Security:
             * This is the primary security aspect we implemented after the code was developed.
             * When the user transitions between the home page to the card, the card form is opened, but before, the home form stayed open.
             * So, we made sure to HIDE THE FORM to not allow access to two forms at once (as this could compromise data).
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addDeck(Deck newDeck)
        {
            decks.Add(newDeck);
            listBox1.Items.Add(newDeck.GetName());
        }

        private void btn_h_newDeck_Click_1(object sender, EventArgs e)
        {
            CreateDeck createDeck = new CreateDeck();
            this.Hide();
            createDeck.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Import import = new(homeDir);
            this.Hide();
            import.Show();
        }
    }
}
