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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\madal\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;

            if(AccNume.Text == "" || 
                AccNum.Text == "" || 
                AccPrenume.Text == ""|| 
                Telefon.Text == "" || 
                Address.Text == "" || 
                Ocupatie.Text == "" ||
                PIN.Text == "")
            {
                MessageBox.Show("Completati toate campurile");
            }
            else
            {
                try
                {
                    conn.Open();                                   // '"+AccNume.Text+"', '"+ +"'
                    string query = "insert into AccountTbl values('"+AccNum.Text+"', '"+AccNume.Text+"', '"+AccPrenume.Text+"', '"+Telefon.Text+"', '"+Address.Text+"', '"+Ocupatie.Text+"', '"+PIN.Text+"', '"+bal+"')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cont creat cu succes");
                    conn.Close();

                    Login log = new Login();

                    log.Show();
                    this.Hide();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
