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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        public static string AccNumber;

        private void HOME_Load(object sender, EventArgs e)
        {
            NrCont.Text = "Numar Cont: " + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePIN changePIN = new ChangePIN();
            changePIN.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Retragere retragere = new Retragere();
            retragere.Show();
            this.Hide();
        }

        private void tranzatiiAnterioareBTN_Click(object sender, EventArgs e)
        {
            Tranzactii t = new Tranzactii();
            t.Show();
            this.Hide();
        }
    }
}
