namespace FlashFrenzy
{
    partial class AddCard
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
            addCardTerm = new TextBox();
            button1 = new Button();
            addCardDefinition = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // addCardTerm
            // 
            addCardTerm.Location = new Point(220, 46);
            addCardTerm.Margin = new Padding(2, 2, 2, 2);
            addCardTerm.Name = "addCardTerm";
            addCardTerm.Size = new Size(162, 23);
            addCardTerm.TabIndex = 0;
            addCardTerm.TextChanged += addCardTerm_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(260, 206);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 2;
            button1.Text = "Add Card";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addCardDefinition
            // 
            addCardDefinition.Location = new Point(220, 92);
            addCardDefinition.Margin = new Padding(2, 2, 2, 2);
            addCardDefinition.Name = "addCardDefinition";
            addCardDefinition.Size = new Size(162, 88);
            addCardDefinition.TabIndex = 3;
            addCardDefinition.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Term:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Definition:";
            // 
            // AddCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addCardDefinition);
            Controls.Add(button1);
            Controls.Add(addCardTerm);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddCard";
            Text = "AddCard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addCardTerm;
        private Button button1;
        private RichTextBox addCardDefinition;
        private Label label1;
        private Label label2;
    }
}