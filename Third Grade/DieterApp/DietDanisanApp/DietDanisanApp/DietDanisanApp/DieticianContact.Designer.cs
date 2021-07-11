namespace DietDanisanApp
{
    partial class DieticianContact
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieticianContact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dieticianInfoGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.senderMailTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.mailSubjectTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieticianInfoGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DietDanisanApp.Properties.Resources.dieticianContact;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dieticianInfoGridView
            // 
            this.dieticianInfoGridView.AllowUserToAddRows = false;
            this.dieticianInfoGridView.AllowUserToDeleteRows = false;
            this.dieticianInfoGridView.AllowUserToResizeColumns = false;
            this.dieticianInfoGridView.AllowUserToResizeRows = false;
            this.dieticianInfoGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dieticianInfoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dieticianInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dieticianInfoGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dieticianInfoGridView.Location = new System.Drawing.Point(595, 12);
            this.dieticianInfoGridView.MultiSelect = false;
            this.dieticianInfoGridView.Name = "dieticianInfoGridView";
            this.dieticianInfoGridView.ReadOnly = true;
            this.dieticianInfoGridView.RowHeadersVisible = false;
            this.dieticianInfoGridView.RowHeadersWidth = 51;
            this.dieticianInfoGridView.RowTemplate.Height = 24;
            this.dieticianInfoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dieticianInfoGridView.Size = new System.Drawing.Size(436, 150);
            this.dieticianInfoGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.senderMailTxt);
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.mailTxt);
            this.groupBox1.Controls.Add(this.mailSubjectTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(595, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 303);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sender Mail";
            // 
            // senderMailTxt
            // 
            this.senderMailTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.senderMailTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.senderMailTxt.Location = new System.Drawing.Point(128, 27);
            this.senderMailTxt.MaxLength = 255;
            this.senderMailTxt.Name = "senderMailTxt";
            this.senderMailTxt.ReadOnly = true;
            this.senderMailTxt.Size = new System.Drawing.Size(260, 31);
            this.senderMailTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.passwordTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTxt.Location = new System.Drawing.Point(128, 70);
            this.passwordTxt.MaxLength = 50;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(260, 31);
            this.passwordTxt.TabIndex = 3;
            // 
            // mailTxt
            // 
            this.mailTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mailTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTxt.Location = new System.Drawing.Point(128, 166);
            this.mailTxt.Multiline = true;
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mailTxt.Size = new System.Drawing.Size(260, 128);
            this.mailTxt.TabIndex = 5;
            // 
            // mailSubjectTxt
            // 
            this.mailSubjectTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mailSubjectTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailSubjectTxt.Location = new System.Drawing.Point(128, 113);
            this.mailSubjectTxt.MaxLength = 100;
            this.mailSubjectTxt.Name = "mailSubjectTxt";
            this.mailSubjectTxt.Size = new System.Drawing.Size(260, 31);
            this.mailSubjectTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendButton.Location = new System.Drawing.Point(768, 499);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(109, 33);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // DieticianContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1063, 544);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dieticianInfoGridView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DieticianContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Dieters";
            this.Load += new System.EventHandler(this.DieticianContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieticianInfoGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dieticianInfoGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox mailSubjectTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senderMailTxt;
        private System.Windows.Forms.TextBox passwordTxt;
    }
}