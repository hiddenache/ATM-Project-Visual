using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class Tranzactii : Form
    {
        public Tranzactii()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madalin\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            conn.Open();
            string query = "select * from Transactions where AccNum='" + HOME.AccNumber + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            
            gridViewTranzactii.DataSource = dataSet.Tables[0];

            conn.Close();
        }
        
        private void Tranzactii_Load(object sender, EventArgs e)
        {
            accNum.Text = HOME.AccNumber;
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
