using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 5;

            progressBar1.Value = start;
            Myprogress.Text = "" + start + "%";

            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();

                timer1.Interval = 5;
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
