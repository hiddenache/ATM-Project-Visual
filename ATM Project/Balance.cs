using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Project
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\madal\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void sold()
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Sold FROM AccountTbl WHERE NrAcc='"+NrCont.Text+"'", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            SoldInRon.Text = "RON " + dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            NrCont.Text = HOME.AccNumber;
            sold();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
