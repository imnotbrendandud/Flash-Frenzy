namespace FlashFrenzy
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btn_h_newDeck = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 83);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 225);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(613, 131);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(140, 55);
            button1.TabIndex = 1;
            button1.Text = "Select Deck";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_h_newDeck
            // 
            btn_h_newDeck.Location = new Point(631, 198);
            btn_h_newDeck.Margin = new Padding(2);
            btn_h_newDeck.Name = "btn_h_newDeck";
            btn_h_newDeck.Size = new Size(106, 31);
            btn_h_newDeck.TabIndex = 2;
            btn_h_newDeck.Text = "New Deck";
            btn_h_newDeck.UseVisualStyleBackColor = true;
            btn_h_newDeck.Click += btn_h_newDeck_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(632, 270);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(106, 31);
            button4.TabIndex = 4;
            button4.Text = "Settings";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(416, 131);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(154, 139);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 7;
            label1.Text = "My Decks:";
            // 
            // button2
            // 
            button2.Location = new Point(632, 234);
            button2.Name = "button2";
            button2.Size = new Size(106, 31);
            button2.TabIndex = 8;
            button2.Text = "Import Deck";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 421);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(btn_h_newDeck);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Home";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn_h_newDeck_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button btn_h_newDeck;
        private Button button4;
        private ListBox listBox1;
        private Label label1;
        private Button button2;
    }
}