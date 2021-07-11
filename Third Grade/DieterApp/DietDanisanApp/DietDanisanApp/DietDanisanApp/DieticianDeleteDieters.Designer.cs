namespace DietDanisanApp
{
    partial class DieticianDeleteDieters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieticianDeleteDieters));
            this.dieterDataView = new System.Windows.Forms.DataGridView();
            this.deleteListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteAppBtn = new System.Windows.Forms.Button();
            this.deleteDieterBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteExerciseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dieterDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dieterDataView
            // 
            this.dieterDataView.AllowUserToAddRows = false;
            this.dieterDataView.AllowUserToDeleteRows = false;
            this.dieterDataView.AllowUserToResizeColumns = false;
            this.dieterDataView.AllowUserToResizeRows = false;
            this.dieterDataView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dieterDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dieterDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dieterDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dieterDataView.Location = new System.Drawing.Point(12, 79);
            this.dieterDataView.MultiSelect = false;
            this.dieterDataView.Name = "dieterDataView";
            this.dieterDataView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dieterDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dieterDataView.RowHeadersVisible = false;
            this.dieterDataView.RowHeadersWidth = 51;
            this.dieterDataView.RowTemplate.Height = 24;
            this.dieterDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dieterDataView.Size = new System.Drawing.Size(403, 160);
            this.dieterDataView.TabIndex = 0;
            // 
            // deleteListBtn
            // 
            this.deleteListBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.deleteListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteListBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteListBtn.Location = new System.Drawing.Point(445, 79);
            this.deleteListBtn.Name = "deleteListBtn";
            this.deleteListBtn.Size = new System.Drawing.Size(226, 34);
            this.deleteListBtn.TabIndex = 1;
            this.deleteListBtn.Text = "Delete Diet List";
            this.deleteListBtn.UseVisualStyleBackColor = false;
            this.deleteListBtn.Click += new System.EventHandler(this.deleteListBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delete ";
            // 
            // deleteAppBtn
            // 
            this.deleteAppBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.deleteAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteAppBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteAppBtn.Location = new System.Drawing.Point(445, 163);
            this.deleteAppBtn.Name = "deleteAppBtn";
            this.deleteAppBtn.Size = new System.Drawing.Size(226, 34);
            this.deleteAppBtn.TabIndex = 4;
            this.deleteAppBtn.Text = "Delete All Appointments";
            this.deleteAppBtn.UseVisualStyleBackColor = false;
            this.deleteAppBtn.Click += new System.EventHandler(this.deleteAppBtn_Click);
            // 
            // deleteDieterBtn
            // 
            this.deleteDieterBtn.BackColor = System.Drawing.Color.Coral;
            this.deleteDieterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteDieterBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteDieterBtn.Location = new System.Drawing.Point(445, 205);
            this.deleteDieterBtn.Name = "deleteDieterBtn";
            this.deleteDieterBtn.Size = new System.Drawing.Size(226, 34);
            this.deleteDieterBtn.TabIndex = 5;
            this.deleteDieterBtn.Text = "Delete Dieter";
            this.deleteDieterBtn.UseVisualStyleBackColor = false;
            this.deleteDieterBtn.Click += new System.EventHandler(this.deleteDieterBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DietDanisanApp.Properties.Resources.delete1;
            this.pictureBox1.Location = new System.Drawing.Point(80, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // deleteExerciseButton
            // 
            this.deleteExerciseButton.BackColor = System.Drawing.Color.Gold;
            this.deleteExerciseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteExerciseButton.ForeColor = System.Drawing.Color.Black;
            this.deleteExerciseButton.Location = new System.Drawing.Point(445, 121);
            this.deleteExerciseButton.Name = "deleteExerciseButton";
            this.deleteExerciseButton.Size = new System.Drawing.Size(226, 34);
            this.deleteExerciseButton.TabIndex = 6;
            this.deleteExerciseButton.Text = "Delete Exercise List";
            this.deleteExerciseButton.UseVisualStyleBackColor = false;
            this.deleteExerciseButton.Click += new System.EventHandler(this.deleteExerciseButton_Click);
            // 
            // DieticianDeleteDieters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 563);
            this.Controls.Add(this.deleteExerciseButton);
            this.Controls.Add(this.deleteDieterBtn);
            this.Controls.Add(this.deleteAppBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteListBtn);
            this.Controls.Add(this.dieterDataView);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DieticianDeleteDieters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DieticianDeleteDieters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dieterDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dieterDataView;
        private System.Windows.Forms.Button deleteListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deleteAppBtn;
        private System.Windows.Forms.Button deleteDieterBtn;
        private System.Windows.Forms.Button deleteExerciseButton;
    }
}