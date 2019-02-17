using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDNumberInquiry
{
    public partial class IDNumberInquiry : Form
    {
        public IDNumberInquiry()
        {
            InitializeComponent();
        }

        private void IDNumberInquiry_Load(object sender, EventArgs e)
        {
            this.IDNumberTextBox.Text = "";
        }

        private void IDNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else if (IDNumberTextBox.Text.Length == 17 && (e.KeyChar == 'X' || e.KeyChar == 'x'))
                e.Handled = false;
            else if (e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            Boolean flag = validateId();

        }
        
        //校验身份证号
        private Boolean validateId()
        {
            return true;
        }
    }
}
