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
    public partial class NumericTextBox : UserControl
    {
        public NumericTextBox()
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
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(e.KeyChar == '.' && richTextBox1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
        }
    }
}
