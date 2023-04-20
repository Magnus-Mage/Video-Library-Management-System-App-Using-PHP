using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VLMSApp
{
    public partial class FormLogincs : Form
    {
        public FormLogincs()
        {
            InitializeComponent();
        }
        
        MySqlConnection connection = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=root;database=vlms;");


        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            
            connection.Open();

            MySqlCommand command = new MySqlCommand();

            /*if (txtUsername.Text == "ADMIN" && txtPassword.Text == "12345")
            {
                new Form1().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Your Username or Password are Incorrect");
                txtUsername.Clear();
                txtPassword.Clear();
            }*/

            /*string getUsername = "%" + txtUsername + "%";
            string getPassword = "%" + txtPassword + "%";*/


            String username, password;

            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                String query = "SELECT * FROM login_data WHERE username = '"+txtUsername.Text +"' AND password = '" + txtPassword.Text + "'";
                
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtPassword.Text;
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    txtUsername.Clear();
                    txtPassword.Clear();

                    //to focus username

                    txtUsername.Focus();
                }

               
            }
            catch
            {
                MessageBox.Show("ERROR");
                txtUsername.Clear();
                txtPassword.Clear();

            }
            finally
            {
                connection.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void signUp_Click(object sender, EventArgs e)
        {
            new FormSignUp().Show();
            this.Hide();
        }
    }
}
