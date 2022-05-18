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
    public partial class Retragere : Form
    {
        public Retragere()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madalin\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
        int sold;
        private void showSold()
        {
            conn.Open();

            string query = "select Sold from AccountTbl where NrAcc='" + HOME.AccNumber + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            soldRetragere.Text = dt.Rows[0][0].ToString();

            sold = Convert.ToInt32(dt.Rows[0][0].ToString());

            conn.Close();
        }

        private void Retragere_Load(object sender, EventArgs e)
        {
            showSold();
        }

        private void addTransaction(int baniRetrasi)
        {
            string transactionType = "Retragere";
            try
            {
                conn.Open();                                   // '"+AccNume.Text+"', '"+ +"'
                string query = "insert into Transactions values('" + HOME.AccNumber + "', '" + transactionType + "','" + baniRetrasi.ToString() + "', '" + DateTime.Today.Date.ToShortDateString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sold < 100)
            {
                MessageBox.Show("Nu aveti suficienti bani!");
            }
            else
            {
                int soldNou = sold - 100;
                conn.Open();

                string query = "update AccountTbl set Sold= "+soldNou+" WHERE NrAcc="+HOME.AccNumber+"";

                 SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                 DataTable dt = new DataTable();
                 adapter.Fill(dt);
                
                    
                conn.Close();
                addTransaction(100);

                HOME home = new HOME();
                home.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sold < 200)
            {
                MessageBox.Show("Nu aveti suficienti bani!");
            }
            else
            {
                int soldNou = sold - 200;
                conn.Open();

                string query = "update AccountTbl set Sold= " + soldNou + " WHERE NrAcc=" + HOME.AccNumber + "";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                addTransaction(200);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sold < 250)
            {
                MessageBox.Show("Nu aveti suficienti bani!");
            }
            else
            {
                int soldNou = sold - 250;
                conn.Open();

                string query = "update AccountTbl set Sold= " + soldNou + " WHERE NrAcc=" + HOME.AccNumber + "";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                addTransaction(250);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sold < 500)
            {
                MessageBox.Show("Nu aveti suficienti bani!");
            }
            else
            {
                int soldNou = sold - 500;
                conn.Open();

                string query = "update AccountTbl set Sold= " + soldNou + " WHERE NrAcc=" + HOME.AccNumber + "";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                addTransaction(500);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sold < 700)
            {
                MessageBox.Show("Nu aveti suficienti bani!");
            }
            else
            {
                int soldNou = sold - 700;
                conn.Open();

                string query = "update AccountTbl set Sold= " + soldNou + " WHERE NrAcc=" + HOME.AccNumber + "";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();

                addTransaction(700);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sold < 900)
            {
                MessageBox.Show("Nu aveti suficienti bani!");
            }
            else
            {
                int soldNou = sold - 900;
                conn.Open();

                string query = "update AccountTbl set Sold= " + soldNou + " WHERE NrAcc=" + HOME.AccNumber + "";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                conn.Close();
                addTransaction(900);

                HOME home = new HOME();
                home.Show();
                this.Hide();
            }
        }
    }
}
