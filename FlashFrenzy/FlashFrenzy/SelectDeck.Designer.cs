namespace FlashFrenzy
{
    partial class SelectDeck
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Terms = new DataGridViewTextBoxColumn();
            Definitions = new DataGridViewTextBoxColumn();
            Mastery = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            button7 = new Button();
            Import = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(803, 272);
            button1.Name = "button1";
            button1.Size = new Size(206, 102);
            button1.TabIndex = 0;
            button1.Text = "Study!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(858, 405);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 1;
            button2.Text = "Configure";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Terms, Definitions, Mastery });
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(54, 97);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(590, 483);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Terms
            // 
            Terms.Frozen = true;
            Terms.HeaderText = "Terms";
            Terms.MinimumWidth = 8;
            Terms.Name = "Terms";
            Terms.Resizable = DataGridViewTriState.False;
            Terms.Width = 200;
            // 
            // Definitions
            // 
            Definitions.Frozen = true;
            Definitions.HeaderText = "Definitions";
            Definitions.MinimumWidth = 8;
            Definitions.Name = "Definitions";
            Definitions.Resizable = DataGridViewTriState.False;
            Definitions.Width = 250;
            // 
            // Mastery
            // 
            Mastery.Frozen = true;
            Mastery.HeaderText = "Mastery";
            Mastery.MinimumWidth = 8;
            Mastery.Name = "Mastery";
            Mastery.ReadOnly = true;
            Mastery.Resizable = DataGridViewTriState.False;
            Mastery.Width = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 67);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 3;
            label1.Text = "Words:";
            // 
            // button3
            // 
            button3.Location = new Point(299, 623);
            button3.Name = "button3";
            button3.Size = new Size(111, 33);
            button3.TabIndex = 4;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(54, 623);
            button4.Name = "button4";
            button4.Size = new Size(111, 33);
            button4.TabIndex = 5;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(533, 623);
            button5.Name = "button5";
            button5.Size = new Size(111, 33);
            button5.TabIndex = 6;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1027, 623);
            button6.Name = "button6";
            button6.Size = new Size(111, 33);
            button6.TabIndex = 7;
            button6.Text = "Home";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(736, 148);
            label2.Name = "label2";
            label2.Size = new Size(364, 86);
            label2.TabIndex = 8;
            label2.Text = "Deck Name";
            // 
            // button7
            // 
            button7.Location = new Point(1040, 14);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(134, 35);
            button7.TabIndex = 9;
            button7.Text = "Load";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Import
            // 
            Import.Location = new Point(870, 10);
            Import.Margin = new Padding(4, 5, 4, 5);
            Import.Name = "Import";
            Import.Size = new Size(151, 43);
            Import.TabIndex = 11;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = true;
            Import.Click += button8_Click;
            // 
            // SelectDeck
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 702);
            Controls.Add(Import);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SelectDeck";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button7;
        private Button Import;
        private Button button8;
        private DataGridViewTextBoxColumn Terms;
        private DataGridViewTextBoxColumn Definitions;
        private DataGridViewTextBoxColumn Mastery;
    }
}