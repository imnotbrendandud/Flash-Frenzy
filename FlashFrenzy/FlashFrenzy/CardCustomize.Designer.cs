namespace FlashFrenzy
{
    partial class CardCustomize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxFont = new ComboBox();
            comboBoxTextColor = new ComboBox();
            comboBoxBackgroundColor = new ComboBox();
            label1 = new Label();
            Font_label = new Label();
            text_color_label = new Label();
            Apply_Changes = new Button();
            Cancel = new Button();
            Back_ground_color_label = new Label();
            preview_panel = new Panel();
            SuspendLayout();
            // 
            // comboBoxFont
            // 
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.Location = new Point(71, 73);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.Size = new Size(121, 23);
            comboBoxFont.TabIndex = 0;
            comboBoxFont.SelectedIndexChanged += comboBoxFont_SelectedIndexChanged;
            // 
            // comboBoxTextColor
            // 
            comboBoxTextColor.FormattingEnabled = true;
            comboBoxTextColor.Location = new Point(71, 133);
            comboBoxTextColor.Name = "comboBoxTextColor";
            comboBoxTextColor.Size = new Size(121, 23);
            comboBoxTextColor.TabIndex = 1;
            comboBoxTextColor.SelectedIndexChanged += comboBoxTextColor_SelectedIndexChanged;
            // 
            // comboBoxBackgroundColor
            // 
            comboBoxBackgroundColor.FormattingEnabled = true;
            comboBoxBackgroundColor.Location = new Point(71, 197);
            comboBoxBackgroundColor.Name = "comboBoxBackgroundColor";
            comboBoxBackgroundColor.Size = new Size(121, 23);
            comboBoxBackgroundColor.TabIndex = 2;
            comboBoxBackgroundColor.SelectedIndexChanged += comboBoxBackgroundColor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 3;
            label1.Text = "Customize Your Card";
            // 
            // Font_label
            // 
            Font_label.AutoSize = true;
            Font_label.Location = new Point(112, 55);
            Font_label.Name = "Font_label";
            Font_label.Size = new Size(31, 15);
            Font_label.TabIndex = 4;
            Font_label.Text = "Font";
            // 
            // text_color_label
            // 
            text_color_label.AutoSize = true;
            text_color_label.Location = new Point(103, 115);
            text_color_label.Name = "text_color_label";
            text_color_label.Size = new Size(60, 15);
            text_color_label.TabIndex = 5;
            text_color_label.Text = "Text Color";
            // 
            // Apply_Changes
            // 
            Apply_Changes.Location = new Point(581, 415);
            Apply_Changes.Name = "Apply_Changes";
            Apply_Changes.Size = new Size(75, 23);
            Apply_Changes.TabIndex = 6;
            Apply_Changes.Text = "Apply";
            Apply_Changes.UseVisualStyleBackColor = true;
            Apply_Changes.Click += Apply_Changes_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(687, 415);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 7;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Back_ground_color_label
            // 
            Back_ground_color_label.AutoSize = true;
            Back_ground_color_label.Location = new Point(80, 179);
            Back_ground_color_label.Name = "Back_ground_color_label";
            Back_ground_color_label.Size = new Size(103, 15);
            Back_ground_color_label.TabIndex = 8;
            Back_ground_color_label.Text = "Background Color";
            Back_ground_color_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // preview_panel
            // 
            preview_panel.Location = new Point(430, 73);
            preview_panel.Name = "preview_panel";
            preview_panel.Size = new Size(332, 190);
            preview_panel.TabIndex = 9;
            // 
            // CardCustomize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(preview_panel);
            Controls.Add(Back_ground_color_label);
            Controls.Add(Cancel);
            Controls.Add(Apply_Changes);
            Controls.Add(text_color_label);
            Controls.Add(Font_label);
            Controls.Add(label1);
            Controls.Add(comboBoxBackgroundColor);
            Controls.Add(comboBoxTextColor);
            Controls.Add(comboBoxFont);
            Name = "CardCustomize";
            Text = "CardCustomize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFont;
        private ComboBox comboBoxTextColor;
        private ComboBox comboBoxBackgroundColor;
        private Label label1;
        private Label Font_label;
        private Label text_color_label;
        private Button Apply_Changes;
        private Button Cancel;
        private Label Back_ground_color_label;
        private Panel preview_panel;
    }
}