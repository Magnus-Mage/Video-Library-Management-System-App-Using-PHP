using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLMSApp
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

      
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtNewUsername.Clear();
            txtEmail.Clear();
            txtNewConfPassword.Clear();
            txtNewPassword.Clear();

            txtNewUsername.Focus();
        }

        private void logInShutter_Click(object sender, EventArgs e)
        {
            new FormLogincs().Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(txtNewConfPassword != txtNewPassword)
            {
                MessageBox.Show("Password does not match. Please Retry");

                txtNewUsername.Clear();
                txtEmail.Clear();
                txtNewConfPassword.Clear();
                txtNewPassword.Clear();

                txtNewUsername.Focus();
            }
            //add a new item to the database
            loginInfo logininfo = new loginInfo
            {
                username = txtNewUsername.Text,
                password = txtNewPassword.Text,
            };

            VideoDAO videoDAO = new VideoDAO();
            int result = videoDAO.addNewLogin(logininfo);
            
        }
    }
}
