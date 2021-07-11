namespace DietDanisanApp
{
    partial class DieticianAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieticianAppointment));
            this.label1 = new System.Windows.Forms.Label();
            this.pendingGridView = new System.Windows.Forms.DataGridView();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registeredAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registeredPanel = new System.Windows.Forms.Panel();
            this.pendingPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnToPending = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.registeredGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pendingGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.registeredPanel.SuspendLayout();
            this.pendingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(300, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Appointments";
            // 
            // pendingGridView
            // 
            this.pendingGridView.AllowUserToAddRows = false;
            this.pendingGridView.AllowUserToDeleteRows = false;
            this.pendingGridView.AllowUserToOrderColumns = true;
            this.pendingGridView.AllowUserToResizeColumns = false;
            this.pendingGridView.AllowUserToResizeRows = false;
            this.pendingGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pendingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pendingGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.pendingGridView.Location = new System.Drawing.Point(112, 72);
            this.pendingGridView.MultiSelect = false;
            this.pendingGridView.Name = "pendingGridView";
            this.pendingGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pendingGridView.RowHeadersVisible = false;
            this.pendingGridView.RowHeadersWidth = 51;
            this.pendingGridView.RowTemplate.Height = 24;
            this.pendingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pendingGridView.Size = new System.Drawing.Size(703, 196);
            this.pendingGridView.TabIndex = 1;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirmBtn.Location = new System.Drawing.Point(309, 289);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(139, 29);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "CONFIRM";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn1
            // 
            this.cancelBtn1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelBtn1.Location = new System.Drawing.Point(500, 289);
            this.cancelBtn1.Name = "cancelBtn1";
            this.cancelBtn1.Size = new System.Drawing.Size(139, 29);
            this.cancelBtn1.TabIndex = 3;
            this.cancelBtn1.Text = "CANCEL";
            this.cancelBtn1.UseVisualStyleBackColor = true;
            this.cancelBtn1.Click += new System.EventHandler(this.cancelBtn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem,
            this.registeredAppointmentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.appointmentToolStripMenuItem.Text = "Pending appointments";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // registeredAppointmentsToolStripMenuItem
            // 
            this.registeredAppointmentsToolStripMenuItem.Name = "registeredAppointmentsToolStripMenuItem";
            this.registeredAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.registeredAppointmentsToolStripMenuItem.Text = "Registered appointments";
            this.registeredAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.registeredAppointmentsToolStripMenuItem_Click);
            // 
            // registeredPanel
            // 
            this.registeredPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.registeredPanel.Controls.Add(this.pendingPanel);
            this.registeredPanel.Controls.Add(this.returnToPending);
            this.registeredPanel.Controls.Add(this.cancelBtn);
            this.registeredPanel.Controls.Add(this.registeredGridView);
            this.registeredPanel.Controls.Add(this.label2);
            this.registeredPanel.Controls.Add(this.pictureBox2);
            this.registeredPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registeredPanel.Location = new System.Drawing.Point(0, 28);
            this.registeredPanel.Name = "registeredPanel";
            this.registeredPanel.Size = new System.Drawing.Size(919, 675);
            this.registeredPanel.TabIndex = 6;
            // 
            // pendingPanel
            // 
            this.pendingPanel.BackColor = System.Drawing.Color.Indigo;
            this.pendingPanel.Controls.Add(this.label1);
            this.pendingPanel.Controls.Add(this.pendingGridView);
            this.pendingPanel.Controls.Add(this.confirmBtn);
            this.pendingPanel.Controls.Add(this.cancelBtn1);
            this.pendingPanel.Controls.Add(this.pictureBox1);
            this.pendingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingPanel.Location = new System.Drawing.Point(0, 0);
            this.pendingPanel.Name = "pendingPanel";
            this.pendingPanel.Size = new System.Drawing.Size(919, 675);
            this.pendingPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietDanisanApp.Properties.Resources.dieticianAppointment;
            this.pictureBox1.Location = new System.Drawing.Point(290, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // returnToPending
            // 
            this.returnToPending.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.returnToPending.Location = new System.Drawing.Point(112, 292);
            this.returnToPending.Name = "returnToPending";
            this.returnToPending.Size = new System.Drawing.Size(307, 29);
            this.returnToPending.TabIndex = 9;
            this.returnToPending.Text = "RETURN TO PENDING";
            this.returnToPending.UseVisualStyleBackColor = true;
            this.returnToPending.Click += new System.EventHandler(this.returnToPending_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelBtn.Location = new System.Drawing.Point(552, 292);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(263, 29);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // registeredGridView
            // 
            this.registeredGridView.AllowUserToAddRows = false;
            this.registeredGridView.AllowUserToDeleteRows = false;
            this.registeredGridView.AllowUserToResizeColumns = false;
            this.registeredGridView.AllowUserToResizeRows = false;
            this.registeredGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.registeredGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registeredGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.registeredGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registeredGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.registeredGridView.Location = new System.Drawing.Point(112, 72);
            this.registeredGridView.MultiSelect = false;
            this.registeredGridView.Name = "registeredGridView";
            this.registeredGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registeredGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.registeredGridView.RowHeadersVisible = false;
            this.registeredGridView.RowHeadersWidth = 51;
            this.registeredGridView.RowTemplate.Height = 24;
            this.registeredGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registeredGridView.Size = new System.Drawing.Size(703, 196);
            this.registeredGridView.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(297, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registered Appointments";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DietDanisanApp.Properties.Resources.appointment2;
            this.pictureBox2.Location = new System.Drawing.Point(268, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // DieticianAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 703);
            this.Controls.Add(this.registeredPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DieticianAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.DieticianAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pendingGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.registeredPanel.ResumeLayout(false);
            this.registeredPanel.PerformLayout();
            this.pendingPanel.ResumeLayout(false);
            this.pendingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pendingGridView;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registeredAppointmentsToolStripMenuItem;
        private System.Windows.Forms.Panel registeredPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView registeredGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pendingPanel;
        private System.Windows.Forms.Button returnToPending;
    }
}