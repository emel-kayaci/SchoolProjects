namespace DietDanisanApp
{
    partial class UserMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userWelcomeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showDieticianInformation = new System.Windows.Forms.PictureBox();
            this.updatePhysicalInfo = new System.Windows.Forms.PictureBox();
            this.bmiCalculator = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userSettings = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userReturnToLogin = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userUpdateInfo = new System.Windows.Forms.PictureBox();
            this.userAppointment = new System.Windows.Forms.PictureBox();
            this.userContact = new System.Windows.Forms.PictureBox();
            this.userDieticiansShow = new System.Windows.Forms.PictureBox();
            this.userDietListsShow = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDieticianInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePhysicalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReturnToLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userUpdateInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDieticiansShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDietListsShow)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.userWelcomeLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userSettings);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.userReturnToLogin);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.userUpdateInfo);
            this.panel1.Controls.Add(this.userAppointment);
            this.panel1.Controls.Add(this.userContact);
            this.panel1.Controls.Add(this.userDieticiansShow);
            this.panel1.Controls.Add(this.userDietListsShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 807);
            this.panel1.TabIndex = 0;
            // 
            // userWelcomeLabel
            // 
            this.userWelcomeLabel.AutoSize = true;
            this.userWelcomeLabel.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWelcomeLabel.Location = new System.Drawing.Point(12, 16);
            this.userWelcomeLabel.Name = "userWelcomeLabel";
            this.userWelcomeLabel.Size = new System.Drawing.Size(155, 32);
            this.userWelcomeLabel.TabIndex = 19;
            this.userWelcomeLabel.Text = "User Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Controls.Add(this.showDieticianInformation);
            this.panel3.Controls.Add(this.updatePhysicalInfo);
            this.panel3.Controls.Add(this.bmiCalculator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 756);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 51);
            this.panel3.TabIndex = 23;
            // 
            // showDieticianInformation
            // 
            this.showDieticianInformation.Image = global::DietDanisanApp.Properties.Resources.doctor;
            this.showDieticianInformation.Location = new System.Drawing.Point(268, 3);
            this.showDieticianInformation.Name = "showDieticianInformation";
            this.showDieticianInformation.Size = new System.Drawing.Size(49, 45);
            this.showDieticianInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showDieticianInformation.TabIndex = 24;
            this.showDieticianInformation.TabStop = false;
            this.showDieticianInformation.Click += new System.EventHandler(this.showDieticianInformation_Click);
            // 
            // updatePhysicalInfo
            // 
            this.updatePhysicalInfo.Image = global::DietDanisanApp.Properties.Resources.weighing_scale;
            this.updatePhysicalInfo.Location = new System.Drawing.Point(164, 3);
            this.updatePhysicalInfo.Name = "updatePhysicalInfo";
            this.updatePhysicalInfo.Size = new System.Drawing.Size(49, 45);
            this.updatePhysicalInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatePhysicalInfo.TabIndex = 23;
            this.updatePhysicalInfo.TabStop = false;
            this.updatePhysicalInfo.Click += new System.EventHandler(this.updatePhysicalInfo_Click);
            // 
            // bmiCalculator
            // 
            this.bmiCalculator.Image = global::DietDanisanApp.Properties.Resources.bmi;
            this.bmiCalculator.Location = new System.Drawing.Point(51, 3);
            this.bmiCalculator.Name = "bmiCalculator";
            this.bmiCalculator.Size = new System.Drawing.Size(49, 45);
            this.bmiCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bmiCalculator.TabIndex = 22;
            this.bmiCalculator.TabStop = false;
            this.bmiCalculator.Click += new System.EventHandler(this.bmiCalculator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "SETTINGS";
            // 
            // userSettings
            // 
            this.userSettings.Image = global::DietDanisanApp.Properties.Resources.settingsIcon;
            this.userSettings.Location = new System.Drawing.Point(12, 566);
            this.userSettings.Name = "userSettings";
            this.userSettings.Size = new System.Drawing.Size(88, 85);
            this.userSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userSettings.TabIndex = 20;
            this.userSettings.TabStop = false;
            this.userSettings.Click += new System.EventHandler(this.userSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "PROGRAMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 700);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "RETURN TO LOGIN";
            // 
            // userReturnToLogin
            // 
            this.userReturnToLogin.Image = global::DietDanisanApp.Properties.Resources.backtoLoginIcon;
            this.userReturnToLogin.Location = new System.Drawing.Point(12, 668);
            this.userReturnToLogin.Name = "userReturnToLogin";
            this.userReturnToLogin.Size = new System.Drawing.Size(88, 85);
            this.userReturnToLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userReturnToLogin.TabIndex = 17;
            this.userReturnToLogin.TabStop = false;
            this.userReturnToLogin.Click += new System.EventHandler(this.userReturnToLogin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(106, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "CONTACT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(106, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "APPOINTMENT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(108, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "DIETICIANS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(108, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "UPDATE INFO";
            // 
            // userUpdateInfo
            // 
            this.userUpdateInfo.Image = global::DietDanisanApp.Properties.Resources.updateInfoIcon;
            this.userUpdateInfo.Location = new System.Drawing.Point(12, 163);
            this.userUpdateInfo.Name = "userUpdateInfo";
            this.userUpdateInfo.Size = new System.Drawing.Size(88, 85);
            this.userUpdateInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userUpdateInfo.TabIndex = 4;
            this.userUpdateInfo.TabStop = false;
            this.userUpdateInfo.Click += new System.EventHandler(this.userUpdateInfo_Click);
            // 
            // userAppointment
            // 
            this.userAppointment.Image = global::DietDanisanApp.Properties.Resources.resIcon;
            this.userAppointment.Location = new System.Drawing.Point(12, 364);
            this.userAppointment.Name = "userAppointment";
            this.userAppointment.Size = new System.Drawing.Size(88, 85);
            this.userAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAppointment.TabIndex = 3;
            this.userAppointment.TabStop = false;
            this.userAppointment.Click += new System.EventHandler(this.userAppointment_Click);
            // 
            // userContact
            // 
            this.userContact.Image = global::DietDanisanApp.Properties.Resources.contactIcon;
            this.userContact.Location = new System.Drawing.Point(12, 463);
            this.userContact.Name = "userContact";
            this.userContact.Size = new System.Drawing.Size(88, 85);
            this.userContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userContact.TabIndex = 2;
            this.userContact.TabStop = false;
            this.userContact.Click += new System.EventHandler(this.userContact_Click);
            // 
            // userDieticiansShow
            // 
            this.userDieticiansShow.Image = global::DietDanisanApp.Properties.Resources.showDieticiansIcon;
            this.userDieticiansShow.Location = new System.Drawing.Point(12, 62);
            this.userDieticiansShow.Name = "userDieticiansShow";
            this.userDieticiansShow.Size = new System.Drawing.Size(88, 85);
            this.userDieticiansShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDieticiansShow.TabIndex = 1;
            this.userDieticiansShow.TabStop = false;
            this.userDieticiansShow.Click += new System.EventHandler(this.userDieticiansShow_Click);
            // 
            // userDietListsShow
            // 
            this.userDietListsShow.Image = global::DietDanisanApp.Properties.Resources.dietAndExerciseProgramsUser;
            this.userDietListsShow.Location = new System.Drawing.Point(12, 263);
            this.userDietListsShow.Name = "userDietListsShow";
            this.userDietListsShow.Size = new System.Drawing.Size(88, 85);
            this.userDietListsShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDietListsShow.TabIndex = 0;
            this.userDietListsShow.TabStop = false;
            this.userDietListsShow.Click += new System.EventHandler(this.userDietListsShow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(367, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 807);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(182, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 106);
            this.label11.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Brush Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 686);
            this.label10.TabIndex = 9;
            this.label10.Text = "W\r\nE\r\nL\r\nC\r\nO\r\nM\r\nE\r\n";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DietDanisanApp.Properties.Resources.dieterMainUser;
            this.pictureBox8.Location = new System.Drawing.Point(154, 44);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(263, 722);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 807);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.UserMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showDieticianInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePhysicalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiCalculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReturnToLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userUpdateInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDieticiansShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDietListsShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox userUpdateInfo;
        private System.Windows.Forms.PictureBox userAppointment;
        private System.Windows.Forms.PictureBox userContact;
        private System.Windows.Forms.PictureBox userDieticiansShow;
        private System.Windows.Forms.PictureBox userDietListsShow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userWelcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userSettings;
        private System.Windows.Forms.PictureBox bmiCalculator;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox updatePhysicalInfo;
        private System.Windows.Forms.PictureBox showDieticianInformation;
        private System.Windows.Forms.PictureBox userReturnToLogin;
    }
}