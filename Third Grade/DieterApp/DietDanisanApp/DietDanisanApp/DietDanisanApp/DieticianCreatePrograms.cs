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
    public partial class DieticianCreatePrograms : Form
    {
        public DieticianCreatePrograms()
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.TileVertical);
            this.WindowState = FormWindowState.Maximized;
        }

        DieticianCreateDiet createDietForm;
        private void createDietListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(createDietForm == null)
            {
                createDietForm = new DieticianCreateDiet();
                createDietForm.MdiParent = this;
                createDietForm.FormClosed += CreateDietForm_FormClosed;
                createDietForm.Show();
            } else // if form already opened do not open the new one just show the existing one 
            {
                createDietForm.Activate();
            }
        }

        private void CreateDietForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createDietForm = null;
        }

        DieticianCreateExercise createExerciseForm;
        private void createExerciseProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createExerciseForm == null)
            {
                createExerciseForm = new DieticianCreateExercise();
                createExerciseForm.MdiParent = this;
                createExerciseForm.FormClosed += CreateExerciseForm_FormClosed;
                createExerciseForm.Show();
            }
            else // if form already opened do not open the new one just show the existing one 
            {
                createExerciseForm.Activate();
            }
        }

        private void CreateExerciseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createExerciseForm = null;
        }
    }
}
