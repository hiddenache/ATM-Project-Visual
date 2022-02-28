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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Cursor = Cursors.Hand;
        }

        public static String AccNumber;

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Madalin\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if(AccNum.Text.Equals("") || PIN.Text.Equals(""))
            {
                MessageBox.Show("Campurile NUME/PIN lipsesc!");
            }
            else
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from AccountTbl where NrAcc = '" + AccNum.Text + "' and PIN = " + PIN.Text + "", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    AccNumber = AccNum.Text;
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Numar cont sau PIN gresit!");
                }
            }
            conn.Close();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AccNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
