namespace DietDanisanApp
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.fixedPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginDieticianButton = new System.Windows.Forms.Button();
            this.passwordDieticianTextBox = new System.Windows.Forms.TextBox();
            this.usernameDieticianTextBox = new System.Windows.Forms.TextBox();
            this.passwordDieticianLabel = new System.Windows.Forms.Label();
            this.usernameDieticianLabel = new System.Windows.Forms.Label();
            this.dieticianLabel = new System.Windows.Forms.Label();
            this.welcomeDietician = new System.Windows.Forms.Label();
            this.dieticianLoginPicture = new System.Windows.Forms.PictureBox();
            this.slidingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userRegistrationLink = new System.Windows.Forms.LinkLabel();
            this.loginUserButton = new System.Windows.Forms.Button();
            this.passwordUserTextBox = new System.Windows.Forms.TextBox();
            this.usernameUserTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userLoginPicture = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.changePanelLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.fixedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dieticianLoginPicture)).BeginInit();
            this.slidingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginPicture)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fixedPanel
            // 
            this.fixedPanel.Controls.Add(this.linkLabel1);
            this.fixedPanel.Controls.Add(this.loginDieticianButton);
            this.fixedPanel.Controls.Add(this.passwordDieticianTextBox);
            this.fixedPanel.Controls.Add(this.usernameDieticianTextBox);
            this.fixedPanel.Controls.Add(this.passwordDieticianLabel);
            this.fixedPanel.Controls.Add(this.usernameDieticianLabel);
            this.fixedPanel.Controls.Add(this.dieticianLabel);
            this.fixedPanel.Controls.Add(this.welcomeDietician);
            this.fixedPanel.Controls.Add(this.dieticianLoginPicture);
            this.fixedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fixedPanel.Location = new System.Drawing.Point(0, 0);
            this.fixedPanel.Name = "fixedPanel";
            this.fixedPanel.Size = new System.Drawing.Size(740, 417);
            this.fixedPanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.linkLabel1.Location = new System.Drawing.Point(480, 333);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(176, 23);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create a new account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginDieticianButton
            // 
            this.loginDieticianButton.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginDieticianButton.Location = new System.Drawing.Point(485, 269);
            this.loginDieticianButton.Name = "loginDieticianButton";
            this.loginDieticianButton.Size = new System.Drawing.Size(166, 36);
            this.loginDieticianButton.TabIndex = 3;
            this.loginDieticianButton.Text = "LOGIN";
            this.loginDieticianButton.UseVisualStyleBackColor = true;
            this.loginDieticianButton.Click += new System.EventHandler(this.loginDieticianButton_Click);
            // 
            // passwordDieticianTextBox
            // 
            this.passwordDieticianTextBox.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordDieticianTextBox.Location = new System.Drawing.Point(467, 221);
            this.passwordDieticianTextBox.MaxLength = 50;
            this.passwordDieticianTextBox.Name = "passwordDieticianTextBox";
            this.passwordDieticianTextBox.PasswordChar = '*';
            this.passwordDieticianTextBox.Size = new System.Drawing.Size(205, 31);
            this.passwordDieticianTextBox.TabIndex = 2;
            this.passwordDieticianTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordDieticianTextBox_KeyDown);
            // 
            // usernameDieticianTextBox
            // 
            this.usernameDieticianTextBox.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameDieticianTextBox.Location = new System.Drawing.Point(467, 178);
            this.usernameDieticianTextBox.MaxLength = 50;
            this.usernameDieticianTextBox.Name = "usernameDieticianTextBox";
            this.usernameDieticianTextBox.Size = new System.Drawing.Size(205, 32);
            this.usernameDieticianTextBox.TabIndex = 1;
            // 
            // passwordDieticianLabel
            // 
            this.passwordDieticianLabel.AutoSize = true;
            this.passwordDieticianLabel.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordDieticianLabel.Location = new System.Drawing.Point(374, 225);
            this.passwordDieticianLabel.Name = "passwordDieticianLabel";
            this.passwordDieticianLabel.Size = new System.Drawing.Size(81, 23);
            this.passwordDieticianLabel.TabIndex = 4;
            this.passwordDieticianLabel.Text = "Password";
            // 
            // usernameDieticianLabel
            // 
            this.usernameDieticianLabel.AutoSize = true;
            this.usernameDieticianLabel.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameDieticianLabel.Location = new System.Drawing.Point(374, 183);
            this.usernameDieticianLabel.Name = "usernameDieticianLabel";
            this.usernameDieticianLabel.Size = new System.Drawing.Size(87, 23);
            this.usernameDieticianLabel.TabIndex = 3;
            this.usernameDieticianLabel.Text = "Username";
            // 
            // dieticianLabel
            // 
            this.dieticianLabel.AutoSize = true;
            this.dieticianLabel.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dieticianLabel.Location = new System.Drawing.Point(549, 90);
            this.dieticianLabel.Name = "dieticianLabel";
            this.dieticianLabel.Size = new System.Drawing.Size(123, 23);
            this.dieticianLabel.TabIndex = 2;
            this.dieticianLabel.Text = "Dietician Login";
            // 
            // welcomeDietician
            // 
            this.welcomeDietician.AutoSize = true;
            this.welcomeDietician.BackColor = System.Drawing.Color.Transparent;
            this.welcomeDietician.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeDietician.Location = new System.Drawing.Point(78, 9);
            this.welcomeDietician.Name = "welcomeDietician";
            this.welcomeDietician.Size = new System.Drawing.Size(608, 81);
            this.welcomeDietician.TabIndex = 1;
            this.welcomeDietician.Text = "WELCOME TO DIETER";
            // 
            // dieticianLoginPicture
            // 
            this.dieticianLoginPicture.Image = global::DietDanisanApp.Properties.Resources.loginDieticianMenu;
            this.dieticianLoginPicture.Location = new System.Drawing.Point(12, 76);
            this.dieticianLoginPicture.Name = "dieticianLoginPicture";
            this.dieticianLoginPicture.Size = new System.Drawing.Size(375, 362);
            this.dieticianLoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dieticianLoginPicture.TabIndex = 0;
            this.dieticianLoginPicture.TabStop = false;
            // 
            // slidingPanel
            // 
            this.slidingPanel.BackColor = System.Drawing.Color.White;
            this.slidingPanel.Controls.Add(this.label1);
            this.slidingPanel.Controls.Add(this.userRegistrationLink);
            this.slidingPanel.Controls.Add(this.loginUserButton);
            this.slidingPanel.Controls.Add(this.passwordUserTextBox);
            this.slidingPanel.Controls.Add(this.usernameUserTextBox);
            this.slidingPanel.Controls.Add(this.label4);
            this.slidingPanel.Controls.Add(this.label3);
            this.slidingPanel.Controls.Add(this.label2);
            this.slidingPanel.Controls.Add(this.userLoginPicture);
            this.slidingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.slidingPanel.Location = new System.Drawing.Point(-1, 0);
            this.slidingPanel.Name = "slidingPanel";
            this.slidingPanel.Size = new System.Drawing.Size(740, 417);
            this.slidingPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 81);
            this.label1.TabIndex = 10;
            this.label1.Text = "WELCOME TO DIETER";
            // 
            // userRegistrationLink
            // 
            this.userRegistrationLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userRegistrationLink.AutoSize = true;
            this.userRegistrationLink.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userRegistrationLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userRegistrationLink.Location = new System.Drawing.Point(487, 332);
            this.userRegistrationLink.Name = "userRegistrationLink";
            this.userRegistrationLink.Size = new System.Drawing.Size(176, 23);
            this.userRegistrationLink.TabIndex = 9;
            this.userRegistrationLink.TabStop = true;
            this.userRegistrationLink.Text = "Create a new account";
            this.userRegistrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userRegistrationLink_LinkClicked);
            // 
            // loginUserButton
            // 
            this.loginUserButton.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserButton.Location = new System.Drawing.Point(495, 269);
            this.loginUserButton.Name = "loginUserButton";
            this.loginUserButton.Size = new System.Drawing.Size(166, 36);
            this.loginUserButton.TabIndex = 3;
            this.loginUserButton.Text = "LOGIN";
            this.loginUserButton.UseVisualStyleBackColor = true;
            this.loginUserButton.Click += new System.EventHandler(this.loginUserButton_Click);
            // 
            // passwordUserTextBox
            // 
            this.passwordUserTextBox.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordUserTextBox.Location = new System.Drawing.Point(473, 221);
            this.passwordUserTextBox.MaxLength = 50;
            this.passwordUserTextBox.Name = "passwordUserTextBox";
            this.passwordUserTextBox.PasswordChar = '*';
            this.passwordUserTextBox.Size = new System.Drawing.Size(211, 31);
            this.passwordUserTextBox.TabIndex = 2;
            this.passwordUserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordUserTextBox_KeyDown);
            // 
            // usernameUserTextBox
            // 
            this.usernameUserTextBox.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameUserTextBox.Location = new System.Drawing.Point(473, 178);
            this.usernameUserTextBox.MaxLength = 50;
            this.usernameUserTextBox.Name = "usernameUserTextBox";
            this.usernameUserTextBox.Size = new System.Drawing.Size(211, 32);
            this.usernameUserTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(386, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(380, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(585, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Login";
            // 
            // userLoginPicture
            // 
            this.userLoginPicture.Image = global::DietDanisanApp.Properties.Resources.loginUser;
            this.userLoginPicture.Location = new System.Drawing.Point(0, 84);
            this.userLoginPicture.Name = "userLoginPicture";
            this.userLoginPicture.Size = new System.Drawing.Size(404, 327);
            this.userLoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userLoginPicture.TabIndex = 1;
            this.userLoginPicture.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bottomPanel.Controls.Add(this.changePanelLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 417);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(739, 33);
            this.bottomPanel.TabIndex = 1;
            // 
            // changePanelLabel
            // 
            this.changePanelLabel.AutoSize = true;
            this.changePanelLabel.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changePanelLabel.Location = new System.Drawing.Point(539, 3);
            this.changePanelLabel.Name = "changePanelLabel";
            this.changePanelLabel.Size = new System.Drawing.Size(189, 23);
            this.changePanelLabel.TabIndex = 11;
            this.changePanelLabel.Text = "Click for Dietician Login";
            this.changePanelLabel.Click += new System.EventHandler(this.changePanelLabel_Click_1);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.slidingPanel);
            this.Controls.Add(this.fixedPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            this.fixedPanel.ResumeLayout(false);
            this.fixedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dieticianLoginPicture)).EndInit();
            this.slidingPanel.ResumeLayout(false);
            this.slidingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginPicture)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fixedPanel;
        private System.Windows.Forms.PictureBox dieticianLoginPicture;
        private System.Windows.Forms.Panel slidingPanel;
        private System.Windows.Forms.PictureBox userLoginPicture;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label passwordDieticianLabel;
        private System.Windows.Forms.Label usernameDieticianLabel;
        private System.Windows.Forms.Label dieticianLabel;
        private System.Windows.Forms.Label welcomeDietician;
        private System.Windows.Forms.Button loginDieticianButton;
        private System.Windows.Forms.TextBox passwordDieticianTextBox;
        private System.Windows.Forms.Button loginUserButton;
        private System.Windows.Forms.TextBox passwordUserTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel userRegistrationLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label changePanelLabel;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.TextBox usernameDieticianTextBox;
        private System.Windows.Forms.TextBox usernameUserTextBox;
    }
}

