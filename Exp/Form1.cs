using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace Exp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int am = 1000;
        public int n = 25;
        public int[] ar = new int[15];
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for(int i = 0; i <= 11; i++)
            {
                ar[i] = r.Next() % 9 + 1;
            }

            for(int i = 2; i <= 11; i++)
            {
                var s = Controls.Find("Label" + Convert.ToString(i), true)[0] as Label;
                s.Text = Convert.ToString(ar[i]);
            }

            timer1.Enabled = true;


        }

        public void push(int c)
        {
            for (int i = 2; i <= 10; i++)
            {
                var s = Controls.Find("Label" + Convert.ToString(i), true)[0] as Label;
                var s1 = Controls.Find("Label" + Convert.ToString(i+1), true)[0] as Label;
                s.Text = s1.Text;
            }
            label11.Text = Convert.ToString(c);
        }

        int[] res = new int[10];


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            push(r.Next()%9+1);

            label2.Text = Convert.ToString(r.Next() % 9 + 1);
            timer1.Interval += 5;
            n -= 1;
            if (n == 0) 
            { 
                timer1.Enabled = false;
                if (textBox1.Text == "") { am += 1000; }
                else
                {
                    if (label6.Text == textBox1.Text)
                    {
                        am += 1000;
                    }
                    else { am -= 100; }
                }
                label1.Text = Convert.ToString(am) + "$";
                n = 25;
                timer1.Interval = 50;
                for(int i = 0; i <= 11; i++)
                {
                    ar[i] = 0;
                }

                
                /*StreamReader sr = new StreamReader("winStat.txt");
                foreach (int i in sw.)*/
                



            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
