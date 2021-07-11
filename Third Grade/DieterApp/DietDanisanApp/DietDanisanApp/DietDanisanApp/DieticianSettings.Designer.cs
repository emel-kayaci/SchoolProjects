namespace DietDanisanApp
{
    partial class DieticianSettings
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieticianSettings));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteAccountBtn = new System.Windows.Forms.PictureBox();
            this.changePasswordBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAccountBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePasswordBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.Location = new System.Drawing.Point(69, 154);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(169, 25);
            label2.TabIndex = 14;
            label2.Text = "Change Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Delete Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 73);
            this.label1.TabIndex = 11;
            this.label1.Text = "Settings";
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Image = global::DietDanisanApp.Properties.Resources.delete;
            this.deleteAccountBtn.Location = new System.Drawing.Point(12, 219);
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.Size = new System.Drawing.Size(51, 46);
            this.deleteAccountBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteAccountBtn.TabIndex = 13;
            this.deleteAccountBtn.TabStop = false;
            this.deleteAccountBtn.Click += new System.EventHandler(this.deleteAccountBtn_Click);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Image = global::DietDanisanApp.Properties.Resources.password;
            this.changePasswordBtn.Location = new System.Drawing.Point(12, 143);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(51, 46);
            this.changePasswordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.changePasswordBtn.TabIndex = 12;
            this.changePasswordBtn.TabStop = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietDanisanApp.Properties.Resources.settingsDietician;
            this.pictureBox1.Location = new System.Drawing.Point(173, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DieticianSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(506, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.deleteAccountBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DieticianSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DieticianSettings";
            ((System.ComponentModel.ISupportInitialize)(this.deleteAccountBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePasswordBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox deleteAccountBtn;
        private System.Windows.Forms.PictureBox changePasswordBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}