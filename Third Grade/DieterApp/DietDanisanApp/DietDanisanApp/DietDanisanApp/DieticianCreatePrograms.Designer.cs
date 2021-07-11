namespace DietDanisanApp
{
    partial class DieticianCreatePrograms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieticianCreatePrograms));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createDietListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createExerciseProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Ebrima", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDietListToolStripMenuItem,
            this.createExerciseProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createDietListToolStripMenuItem
            // 
            this.createDietListToolStripMenuItem.Name = "createDietListToolStripMenuItem";
            this.createDietListToolStripMenuItem.Size = new System.Drawing.Size(140, 27);
            this.createDietListToolStripMenuItem.Text = "Create Diet List";
            this.createDietListToolStripMenuItem.Click += new System.EventHandler(this.createDietListToolStripMenuItem_Click);
            // 
            // createExerciseProgramToolStripMenuItem
            // 
            this.createExerciseProgramToolStripMenuItem.Name = "createExerciseProgramToolStripMenuItem";
            this.createExerciseProgramToolStripMenuItem.Size = new System.Drawing.Size(210, 27);
            this.createExerciseProgramToolStripMenuItem.Text = "Create Exercise Program";
            this.createExerciseProgramToolStripMenuItem.Click += new System.EventHandler(this.createExerciseProgramToolStripMenuItem_Click);
            // 
            // DieticianCreatePrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 853);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DieticianCreatePrograms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Programs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createDietListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createExerciseProgramToolStripMenuItem;
    }
}