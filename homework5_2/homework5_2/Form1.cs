using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateRandomBtn_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int[] a = new int[100];
            for (int i = 0; i < 100; i++)
            {
                a[i] = random.Next(1001);
            }
            for(int i = 0; i < 100; i++)
            {
                if (i % 20 == 0 && i != 0)
                {
                    randomLabel.Text += a[i].ToString() + "\n";
                }
                randomLabel.Text += a[i].ToString() + " ";
            }
            var query1 = from j in a orderby a descending select j;
            int[] b = query1.ToArray();
            for (int i = 0; i < 100; i++)
            {
                if (i % 20 == 0 && i != 0)
                {
                    orderedNum.Text += b[i].ToString() + "\n";
                }
                orderedNum.Text += b[i].ToString() + " ";
            }
            int sum = query1.Sum();
            double average = query1.Average();
            sumLabel.Text = sum.ToString();
            averLabel.Text = average.ToString();
        }
    }
}
