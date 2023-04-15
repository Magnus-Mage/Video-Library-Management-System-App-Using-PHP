using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VLMSApp.Forms
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        BindingSource videoBindingSource = new BindingSource();

        private void DLoadRecord_Click(object sender, EventArgs e)
        {
            VideoDAO videoDAO = new VideoDAO();

            //connect the list to the grid view control

            videoBindingSource.DataSource = videoDAO.getAllVideo_data();

            DdataGridView.DataSource = videoBindingSource;

            DpictureBox.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Wikipedia-logo-v2.svg/225px-Wikipedia-logo-v2.svg.png");
        }

        private void DSearchButton_Click(object sender, EventArgs e)
        {
            VideoDAO videoDAO = new VideoDAO();

            //connect the list to the grid view control

            videoBindingSource.DataSource = videoDAO.searchTitles(DSearch.Text);

            DdataGridView.DataSource = videoBindingSource;
        }

        private void DdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number clicked

            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show("You Clicked row " + rowClicked);

            string image_name = dataGridView.Rows[rowClicked].Cells[10].Value.ToString();

            //MessageBox.Show(" URL " + image_name);

            DpictureBox.Load(image_name);
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
