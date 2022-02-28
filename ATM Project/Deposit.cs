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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madalin\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string AccNum = HOME.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if(soldDepozitat.Text == "" || Convert.ToInt32(soldDepozitat.Text) <= 0)
            {
                MessageBox.Show("Introduceti suma pentru depozitat");
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(soldDepozitat.Text);

                try
                {
                    conn.Open();

                    string query = "update AccountTbl set Sold="+newbalance+" WHERE NrAcc='"+AccNum+"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suma adaugata cu succes");
                    conn.Close();

                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int oldbalance, newbalance;

        private void sold()
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Sold FROM AccountTbl WHERE NrAcc='" + AccNum + "'", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            sold();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
    }
}
