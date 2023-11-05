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
            RowNum = new DataGridViewTextBoxColumn();
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
            button1.Location = new Point(601, 130);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(144, 61);
            button1.TabIndex = 0;
            button1.Text = "Study!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(644, 195);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(71, 20);
            button2.TabIndex = 1;
            button2.Text = "Configure";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RowNum, Terms, Definitions, Mastery });
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(38, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(490, 290);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DefaultValuesNeeded += dataGridView1_DefaultValuesNeeded;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // RowNum
            // 
            RowNum.HeaderText = "#";
            RowNum.Name = "RowNum";
            RowNum.ReadOnly = true;
            RowNum.Width = 50;
            // 
            // Terms
            // 
            Terms.HeaderText = "Terms";
            Terms.MinimumWidth = 8;
            Terms.Name = "Terms";
            Terms.Resizable = DataGridViewTriState.False;
            // 
            // Definitions
            // 
            Definitions.HeaderText = "Definitions";
            Definitions.MinimumWidth = 8;
            Definitions.Name = "Definitions";
            Definitions.Resizable = DataGridViewTriState.False;
            Definitions.Width = 200;
            // 
            // Mastery
            // 
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
            label1.Location = new Point(38, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Words:";
            // 
            // button3
            // 
            button3.Location = new Point(209, 374);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 20);
            button3.TabIndex = 4;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(38, 374);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(78, 20);
            button4.TabIndex = 5;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(373, 374);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(78, 20);
            button5.TabIndex = 6;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(719, 374);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(78, 20);
            button6.TabIndex = 7;
            button6.Text = "Home";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(562, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 59);
            label2.TabIndex = 8;
            label2.Text = "Deck Name";
            // 
            // button7
            // 
            button7.Location = new Point(728, 8);
            button7.Name = "button7";
            button7.Size = new Size(94, 21);
            button7.TabIndex = 9;
            button7.Text = "Load";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Import
            // 
            Import.Location = new Point(609, 6);
            Import.Name = "Import";
            Import.Size = new Size(106, 26);
            Import.TabIndex = 11;
            Import.Text = "Import";
            Import.UseVisualStyleBackColor = true;
            Import.Click += button8_Click;
            // 
            // SelectDeck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 421);
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
            Margin = new Padding(2);
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
        private DataGridViewTextBoxColumn RowNum;
        private DataGridViewTextBoxColumn Terms;
        private DataGridViewTextBoxColumn Definitions;
        private DataGridViewTextBoxColumn Mastery;
    }
}