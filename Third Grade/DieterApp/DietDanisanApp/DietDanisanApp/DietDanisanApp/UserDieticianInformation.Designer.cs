namespace DietDanisanApp
{
    partial class UserDieticianInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDieticianInformation));
            this.viewDieticianInfoGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewDieticianInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDieticianInfoGridView
            // 
            this.viewDieticianInfoGridView.AllowUserToAddRows = false;
            this.viewDieticianInfoGridView.AllowUserToDeleteRows = false;
            this.viewDieticianInfoGridView.AllowUserToResizeColumns = false;
            this.viewDieticianInfoGridView.AllowUserToResizeRows = false;
            this.viewDieticianInfoGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.viewDieticianInfoGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewDieticianInfoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewDieticianInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewDieticianInfoGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewDieticianInfoGridView.Location = new System.Drawing.Point(114, 85);
            this.viewDieticianInfoGridView.MultiSelect = false;
            this.viewDieticianInfoGridView.Name = "viewDieticianInfoGridView";
            this.viewDieticianInfoGridView.ReadOnly = true;
            this.viewDieticianInfoGridView.RowHeadersVisible = false;
            this.viewDieticianInfoGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.viewDieticianInfoGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewDieticianInfoGridView.RowTemplate.Height = 24;
            this.viewDieticianInfoGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewDieticianInfoGridView.Size = new System.Drawing.Size(596, 59);
            this.viewDieticianInfoGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dietician Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietDanisanApp.Properties.Resources.dieticianInformationUser;
            this.pictureBox1.Location = new System.Drawing.Point(147, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UserDieticianInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(821, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewDieticianInfoGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserDieticianInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserDieticianInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewDieticianInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDieticianInfoGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}