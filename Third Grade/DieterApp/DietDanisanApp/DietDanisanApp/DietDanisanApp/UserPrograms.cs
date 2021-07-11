using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietDanisanApp
{
    public partial class UserPrograms : Form
    {
        public UserPrograms()
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.TileVertical);
            this.WindowState = FormWindowState.Maximized;
        }

        UserDietLists dietListForm;
        private void dietProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dietListForm == null)
            {
                dietListForm = new UserDietLists();
                dietListForm.MdiParent = this;
                dietListForm.FormClosed += DietListForm_FormClosed;
                dietListForm.Show();
            }
            else // if form already opened do not open the new one just show the existing one 
            {
                dietListForm.Activate();
            }
        }

        private void DietListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dietListForm = null;
        }

        UserExerciseProgram exerciseProgramForm;
        private void exerciseProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exerciseProgramForm == null)
            {
                exerciseProgramForm = new UserExerciseProgram();
                exerciseProgramForm.MdiParent = this;
                exerciseProgramForm.FormClosed += ExerciseProgramForm_FormClosed;
                exerciseProgramForm.Show();
            }
            else // if form already opened do not open the new one just show the existing one 
            {
                exerciseProgramForm.Activate();
            }
        }

        private void ExerciseProgramForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            exerciseProgramForm = null;
        }
    }
}
