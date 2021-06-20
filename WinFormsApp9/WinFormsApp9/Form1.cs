using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            var IDNumber = IDNumberBox.Text.ToString();
            if(ValidateID(IDNumber))
            {
                MessageBox.Show("合法输入");
            }
            else
            {
                MessageBox.Show("非法输入");
            }
        }
        private bool ValidateID(string ID)
        {
            return Regex.IsMatch(ID, @"[1-9]\d{5}(19|20|21)\d{2}((0[1-9])|10|11|12)(((0-2)[1-9])|10|20|30|31)\d{3}[0-9Xx]");
        }
    }
}
