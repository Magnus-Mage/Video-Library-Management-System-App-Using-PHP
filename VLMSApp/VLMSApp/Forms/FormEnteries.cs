using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLMSApp.Forms
{
    public partial class FormEnteries : Form
    {
        public FormEnteries()
        {
            InitializeComponent();
        }

        BindingSource videoBindingSource = new BindingSource();
        private void button1_Click(object sender, EventArgs e)
        {
            VideoDAO videoDAO = new VideoDAO();

            //connect the list to the grid view control

            videoBindingSource.DataSource = videoDAO.getAllVideo_data();

            dataGridView1.DataSource = videoBindingSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Wikipedia-logo-v2.svg/225px-Wikipedia-logo-v2.svg.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VideoDAO videoDAO = new VideoDAO();

            //connect the list to the grid view control

            videoBindingSource.DataSource = videoDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = videoBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show("You Clicked row " + rowClicked);

            string image_name = dataGridView.Rows[rowClicked].Cells[10].Value.ToString();

            //MessageBox.Show(" URL " + image_name);

            pictureBox1.Load(image_name);
        }
    }
}
