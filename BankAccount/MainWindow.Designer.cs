namespace BankAccount
{
    partial class MainWindow
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
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTransferUser = new System.Windows.Forms.TextBox();
            this.textBoxTransferNumber = new System.Windows.Forms.TextBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.textBoxAccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccountName.Location = new System.Drawing.Point(93, 12);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.ReadOnly = true;
            this.textBoxAccountName.Size = new System.Drawing.Size(100, 13);
            this.textBoxAccountName.TabIndex = 0;
            this.textBoxAccountName.TextChanged += new System.EventHandler(this.textBoxAccountName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.textBoxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBalance.ForeColor = System.Drawing.Color.Lime;
            this.textBoxBalance.Location = new System.Drawing.Point(135, 139);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(100, 13);
            this.textBoxBalance.TabIndex = 2;
            this.textBoxBalance.TextChanged += new System.EventHandler(this.textBoxBalance_TextChanged);
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(135, 185);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeposit.TabIndex = 4;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Maroon;
            this.buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeposit.Location = new System.Drawing.Point(135, 228);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(75, 20);
            this.buttonDeposit.TabIndex = 7;
            this.buttonDeposit.Text = "deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.Color.Maroon;
            this.buttonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWithdraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWithdraw.Location = new System.Drawing.Point(216, 228);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(75, 20);
            this.buttonWithdraw.TabIndex = 8;
            this.buttonWithdraw.Text = "withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(587, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Transfer";
            // 
            // textBoxTransferUser
            // 
            this.textBoxTransferUser.Location = new System.Drawing.Point(592, 185);
            this.textBoxTransferUser.Name = "textBoxTransferUser";
            this.textBoxTransferUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxTransferUser.TabIndex = 10;
            // 
            // textBoxTransferNumber
            // 
            this.textBoxTransferNumber.Location = new System.Drawing.Point(718, 185);
            this.textBoxTransferNumber.Name = "textBoxTransferNumber";
            this.textBoxTransferNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxTransferNumber.TabIndex = 11;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.Maroon;
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTransfer.Location = new System.Drawing.Point(668, 228);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(75, 23);
            this.buttonTransfer.TabIndex = 12;
            this.buttonTransfer.Text = "transfer";
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(622, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(748, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(853, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 27);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "<---";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Logged in as :";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(955, 465);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.textBoxTransferNumber);
            this.Controls.Add(this.textBoxTransferUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAccountName);
            this.Name = "MainWindow";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTransferUser;
        private System.Windows.Forms.TextBox textBoxTransferNumber;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label5;
    }
}