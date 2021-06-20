using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace homework5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ArrayList array = new ArrayList();
        public void GetPrime()
        {
            for(int i = 6; i <= 100; i++)
            {
                if (Is_prime(i))
                {
                    array.Add(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPrime();
           
                int num = Int32.Parse(questionTextBox.Text);
                for (int i = 0; i < array.Count; i++)
                {
                    for (int j = 0; j < array.Count; j++)
                    {
                        if ((int)array[i] + (int)array[j] == num)
                        {
                            ansTextBox1.Text = ((int)array[i]).ToString();
                            ansTextBox2.Text = ((int)array[j]).ToString();
                    }
                    }
                }
            
           
            
        }
        private bool Is_prime(int a)
        {
            for (int i = 2; i < a; i++)

            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}
