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
    public partial class ChangePIN : Form
    {
        public ChangePIN()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madalin\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private static string AccNum;

        private void button1_Click(object sender, EventArgs e)
        {
            if(newPIN.Text == "" || confirmPIN.Text == "")
            {
                MessageBox.Show("Completati toate campurile!");
            } else if(newPIN.Text != confirmPIN.Text)
            {
                MessageBox.Show("PIN-urile nu sunt identice, va rugam introduceti PIN CORECT!");
            }
            else
            {
                try
                {
                    conn.Open();
                    AccNum = HOME.AccNumber;
                    string query = "update AccountTbl set PIN=" + newPIN.Text + " where NrAcc='" + AccNum + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN MODIFICAT CU SUCCES!");
                    conn.Close();

                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePIN_Load(object sender, EventArgs e)
        {

        }
    }
}
