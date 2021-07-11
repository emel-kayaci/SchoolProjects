namespace DietDanisanApp
{
    partial class DieticianUpdateHealthInformation
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
            this.dietersGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.diseasesTxt = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bloodPressureTxt = new DietDanisanApp.NumericTextBox();
            this.bloodSugarTxt = new DietDanisanApp.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(123, 285);
            this.heightTxt.Size = new System.Drawing.Size(155, 30);
            this.heightTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Size = new System.Drawing.Size(641, 45);
            this.label1.Text = "Update Physical and Health Information";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 349);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(42, 290);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(246, 505);
            this.updateButton.Size = new System.Drawing.Size(216, 31);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 522);
            this.pictureBox1.Size = new System.Drawing.Size(376, 306);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(350, 514);
            this.pictureBox2.Size = new System.Drawing.Size(402, 314);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 402);
            // 
            // bodyFatTxt
            // 
            this.bodyFatTxt.Location = new System.Drawing.Point(123, 395);
            this.bodyFatTxt.Size = new System.Drawing.Size(155, 30);
            this.bodyFatTxt.TabIndex = 3;
            // 
            // weightTxt
            // 
            this.weightTxt.Location = new System.Drawing.Point(123, 342);
            this.weightTxt.Size = new System.Drawing.Size(155, 30);
            this.weightTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(284, 288);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(288, 345);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(289, 399);
            // 
            // dietersGridView
            // 
            this.dietersGridView.AllowUserToAddRows = false;
            this.dietersGridView.AllowUserToDeleteRows = false;
            this.dietersGridView.AllowUserToResizeColumns = false;
            this.dietersGridView.AllowUserToResizeRows = false;
            this.dietersGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dietersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dietersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dietersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dietersGridView.Location = new System.Drawing.Point(36, 68);
            this.dietersGridView.MultiSelect = false;
            this.dietersGridView.Name = "dietersGridView";
            this.dietersGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dietersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dietersGridView.RowHeadersVisible = false;
            this.dietersGridView.RowHeadersWidth = 51;
            this.dietersGridView.RowTemplate.Height = 24;
            this.dietersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dietersGridView.Size = new System.Drawing.Size(685, 186);
            this.dietersGridView.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(372, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Blood Sugar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(372, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Blood Pressure";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(372, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Diseases";
            // 
            // diseasesTxt
            // 
            this.diseasesTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diseasesTxt.Location = new System.Drawing.Point(511, 395);
            this.diseasesTxt.Name = "diseasesTxt";
            this.diseasesTxt.Size = new System.Drawing.Size(191, 96);
            this.diseasesTxt.TabIndex = 6;
            this.diseasesTxt.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(670, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "mmol/L";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(670, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "mm Hg";
            // 
            // bloodPressureTxt
            // 
            this.bloodPressureTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodPressureTxt.Location = new System.Drawing.Point(511, 345);
            this.bloodPressureTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bloodPressureTxt.Name = "bloodPressureTxt";
            this.bloodPressureTxt.Size = new System.Drawing.Size(155, 29);
            this.bloodPressureTxt.TabIndex = 5;
            // 
            // bloodSugarTxt
            // 
            this.bloodSugarTxt.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodSugarTxt.Location = new System.Drawing.Point(511, 286);
            this.bloodSugarTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bloodSugarTxt.Name = "bloodSugarTxt";
            this.bloodSugarTxt.Size = new System.Drawing.Size(155, 29);
            this.bloodSugarTxt.TabIndex = 4;
            // 
            // DieticianUpdateHealthInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 826);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.diseasesTxt);
            this.Controls.Add(this.bloodPressureTxt);
            this.Controls.Add(this.bloodSugarTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dietersGridView);
            this.Name = "DieticianUpdateHealthInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Health Information";
            this.Load += new System.EventHandler(this.DieticianUpdateHealthInformation_Load);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.heightTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.bodyFatTxt, 0);
            this.Controls.SetChildIndex(this.weightTxt, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dietersGridView, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.bloodSugarTxt, 0);
            this.Controls.SetChildIndex(this.bloodPressureTxt, 0);
            this.Controls.SetChildIndex(this.diseasesTxt, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.updateButton, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dietersGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private NumericTextBox bloodSugarTxt;
        private NumericTextBox bloodPressureTxt;
        private System.Windows.Forms.RichTextBox diseasesTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}