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
            addCardTerm.Location = new Point(315, 77);
            addCardTerm.Name = "addCardTerm";
            addCardTerm.Size = new Size(230, 31);
            addCardTerm.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(371, 344);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Add Card";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addCardDefinition
            // 
            addCardDefinition.Location = new Point(315, 153);
            addCardDefinition.Name = "addCardDefinition";
            addCardDefinition.Size = new Size(230, 144);
            addCardDefinition.TabIndex = 3;
            addCardDefinition.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 80);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 4;
            label1.Text = "Term:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 153);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 5;
            label2.Text = "Definition:";
            // 
            // AddCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addCardDefinition);
            Controls.Add(button1);
            Controls.Add(addCardTerm);
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