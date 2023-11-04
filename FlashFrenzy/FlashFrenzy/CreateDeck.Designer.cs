namespace FlashFrenzy
{
    partial class CreateDeck
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
            btn_cD_confirm = new Button();
            btn_cD_back = new Button();
            txt_nameDeck = new Label();
            txtBox_cD_name = new TextBox();
            SuspendLayout();
            // 
            // btn_cD_confirm
            // 
            btn_cD_confirm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cD_confirm.Location = new Point(444, 259);
            btn_cD_confirm.Name = "btn_cD_confirm";
            btn_cD_confirm.Size = new Size(150, 46);
            btn_cD_confirm.TabIndex = 0;
            btn_cD_confirm.Text = "Confirm";
            btn_cD_confirm.UseVisualStyleBackColor = true;
            btn_cD_confirm.Click += btn_cD_confirm_Click;
            // 
            // btn_cD_back
            // 
            btn_cD_back.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cD_back.Location = new Point(200, 259);
            btn_cD_back.Name = "btn_cD_back";
            btn_cD_back.Size = new Size(150, 46);
            btn_cD_back.TabIndex = 0;
            btn_cD_back.Text = "Back";
            btn_cD_back.UseVisualStyleBackColor = true;
            btn_cD_back.Click += btn_cD_back_Click;
            // 
            // txt_nameDeck
            // 
            txt_nameDeck.AutoSize = true;
            txt_nameDeck.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nameDeck.Location = new Point(200, 124);
            txt_nameDeck.Name = "txt_nameDeck";
            txt_nameDeck.Size = new Size(394, 65);
            txt_nameDeck.TabIndex = 1;
            txt_nameDeck.Text = "Name Your Deck!";
            // 
            // txtBox_cD_name
            // 
            txtBox_cD_name.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_cD_name.Location = new Point(200, 192);
            txtBox_cD_name.Name = "txtBox_cD_name";
            txtBox_cD_name.Size = new Size(394, 61);
            txtBox_cD_name.TabIndex = 2;
            // 
            // CreateDeck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox_cD_name);
            Controls.Add(txt_nameDeck);
            Controls.Add(btn_cD_back);
            Controls.Add(btn_cD_confirm);
            Name = "CreateDeck";
            Text = "CreateDeck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cD_confirm;
        private Button btn_cD_back;
        private Label txt_nameDeck;
        private TextBox txtBox_cD_name;
    }
}