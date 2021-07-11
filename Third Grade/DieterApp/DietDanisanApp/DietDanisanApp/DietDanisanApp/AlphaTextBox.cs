using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietDanisanApp
{
    public partial class AlphaTextBox : UserControl
    {
        public AlphaTextBox()
        {
            InitializeComponent();
        }

        public string Text
        {
            get => richTextBox1.Text;
            set => richTextBox1.Text = value;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }
    }
}
