namespace FlashFrenzy
{
    partial class Card
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 67);
            button1.Name = "button1";
            button1.Size = new Size(683, 492);
            button1.TabIndex = 0;
            button1.Text = "Word";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(233, 67);
            button2.Name = "button2";
            button2.Size = new Size(683, 492);
            button2.TabIndex = 1;
            button2.Text = "Word";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(271, 573);
            button3.Name = "button3";
            button3.Size = new Size(111, 33);
            button3.TabIndex = 2;
            button3.Text = "No";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(516, 573);
            button4.Name = "button4";
            button4.Size = new Size(111, 33);
            button4.TabIndex = 3;
            button4.Text = "A little";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(760, 573);
            button5.Name = "button5";
            button5.Size = new Size(111, 33);
            button5.TabIndex = 4;
            button5.Text = "Yes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Dark Mode";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button6
            // 
            button6.Location = new Point(1047, 638);
            button6.Name = "button6";
            button6.Size = new Size(111, 33);
            button6.TabIndex = 6;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(233, 67);
            button7.Name = "button7";
            button7.Size = new Size(683, 492);
            button7.TabIndex = 7;
            button7.Text = "Click to Start";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 702);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Card";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private Button button6;
        private Button button7;
    }
}