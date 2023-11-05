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
    public partial class CardCustomize : Form
    {

        private Card cardToCustomize;
        private Panel previewPanel;
        private Label previewText;

        // Constructor that accepts a Card object
        public CardCustomize(Card card)
        {
            InitializeComponent();


            cardToCustomize = card;


            // Initialize your preview panel and label here
            previewPanel = preview_panel;

            previewText = new Label
            {
                Dock = DockStyle.Fill, // The label will fill the entire panel
                TextAlign = ContentAlignment.MiddleCenter, // The text will be centered within the label
                ForeColor = cardToCustomize.TextColor,
                Font = cardToCustomize.CardFont,
                Text = cardToCustomize.Definition
            };
            previewPanel.Controls.Add(previewText);

            // Populate the ComboBoxes
            PopulateColorComboBox(comboBoxBackgroundColor, ColorTranslator.ToHtml(card.BackgroundColor));
            PopulateColorComboBox(comboBoxTextColor, ColorTranslator.ToHtml(card.TextColor));
            PopulateFontComboBox(comboBoxFont, card.CardFont.Name);


        }

        private void PopulateColorComboBox(ComboBox comboBox, string selectedColor)
        {
            //We can add a list of predefined colors or use System.Drawing.Color properties
            comboBox.Items.Add("Red");
            comboBox.Items.Add("Green");
            comboBox.Items.Add("Blue");
            comboBox.Items.Add("White");
            comboBox.Items.Add("Black");


            comboBox.SelectedItem = selectedColor;
        }

        private void PopulateFontComboBox(ComboBox comboBox, string selectedFont)
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                comboBox.Items.Add(font.Name);
            }

            comboBox.SelectedItem = selectedFont;
        }

        private void UpdatePreview()
        {
            previewPanel.BackColor = cardToCustomize.BackgroundColor;
            previewText.ForeColor = cardToCustomize.TextColor;
            previewText.Font = cardToCustomize.CardFont;
        }



        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the font of the preview text
            string selectedFontName = comboBoxFont.SelectedItem.ToString();
            Font currentFont = previewText.Font;
            Font newFont = new Font(selectedFontName, currentFont.Size, currentFont.Style);
            previewText.Font = newFont;

        }

        private void comboBoxTextColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the text color of the preview text
            string selectedColor = comboBoxTextColor.SelectedItem.ToString();
            previewText.ForeColor = Color.FromName(selectedColor);

        }

        private void comboBoxBackgroundColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the background color of the preview panel
            string selectedColor = comboBoxBackgroundColor.SelectedItem.ToString();
            previewPanel.BackColor = Color.FromName(selectedColor);
        }

        private void Apply_Changes_Click(object sender, EventArgs e)
        {
            // Save the settings from the preview to the card object
            cardToCustomize.BackgroundColor = previewPanel.BackColor;
            cardToCustomize.TextColor = previewText.ForeColor;
            cardToCustomize.CardFont = previewText.Font;

            // Close the customization form
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // Close the customization form without saving changes
            this.Close();
        }
    }
}
