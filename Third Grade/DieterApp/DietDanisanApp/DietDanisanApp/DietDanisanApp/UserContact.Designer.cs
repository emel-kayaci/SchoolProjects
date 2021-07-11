namespace DietDanisanApp
{
    partial class UserContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserContact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.receiverMailTxt = new System.Windows.Forms.TextBox();
            this.senderMailTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DietDanisanApp.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(518, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receiver Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(518, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sender Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(518, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mail";
            // 
            // receiverMailTxt
            // 
            this.receiverMailTxt.BackColor = System.Drawing.Color.Gold;
            this.receiverMailTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.receiverMailTxt.Location = new System.Drawing.Point(661, 28);
            this.receiverMailTxt.MaxLength = 255;
            this.receiverMailTxt.Name = "receiverMailTxt";
            this.receiverMailTxt.ReadOnly = true;
            this.receiverMailTxt.Size = new System.Drawing.Size(294, 31);
            this.receiverMailTxt.TabIndex = 1;
            // 
            // senderMailTxt
            // 
            this.senderMailTxt.BackColor = System.Drawing.Color.Gold;
            this.senderMailTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.senderMailTxt.Location = new System.Drawing.Point(661, 78);
            this.senderMailTxt.MaxLength = 255;
            this.senderMailTxt.Name = "senderMailTxt";
            this.senderMailTxt.Size = new System.Drawing.Size(294, 31);
            this.senderMailTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.Gold;
            this.passwordTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTxt.Location = new System.Drawing.Point(661, 132);
            this.passwordTxt.MaxLength = 50;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(294, 31);
            this.passwordTxt.TabIndex = 3;
            // 
            // mailTxt
            // 
            this.mailTxt.BackColor = System.Drawing.Color.Gold;
            this.mailTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTxt.Location = new System.Drawing.Point(139, 75);
            this.mailTxt.Multiline = true;
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mailTxt.Size = new System.Drawing.Size(237, 160);
            this.mailTxt.TabIndex = 5;
            // 
            // sendMailButton
            // 
            this.sendMailButton.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendMailButton.Location = new System.Drawing.Point(661, 452);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(119, 31);
            this.sendMailButton.TabIndex = 9;
            this.sendMailButton.Text = "SEND";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // subjectTxt
            // 
            this.subjectTxt.BackColor = System.Drawing.Color.Gold;
            this.subjectTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subjectTxt.Location = new System.Drawing.Point(139, 24);
            this.subjectTxt.MaxLength = 100;
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(237, 31);
            this.subjectTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subject";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mailTxt);
            this.groupBox1.Controls.Add(this.subjectTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(522, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 248);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail";
            // 
            // UserContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(993, 508);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.senderMailTxt);
            this.Controls.Add(this.receiverMailTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.UserContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox receiverMailTxt;
        private System.Windows.Forms.TextBox senderMailTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}