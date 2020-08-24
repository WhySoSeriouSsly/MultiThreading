using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Thread kanal1 = new Thread(new ThreadStart(Counter1));
            Thread kanal2 = new Thread(new ThreadStart(Counter2));
            CheckForIllegalCrossThreadCalls = false;
            kanal1.Start();
            kanal2.Start();
        }
        private void Counter1()
        {
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);
                label1.Text = i + " ";
            }
        }
        private void Counter2()
        {
            Thread.Sleep(500);
            for (int i = 1; i <= 30; i++)
            {
                Thread.Sleep(500);
                label2.Text = i + " ";
                if (i==15)
                {
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
