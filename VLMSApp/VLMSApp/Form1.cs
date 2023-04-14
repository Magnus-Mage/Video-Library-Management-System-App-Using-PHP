namespace VLMSApp
{
    public partial class Form1 : Form
    {
        BindingSource videoBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoDAO videoDAO = new VideoDAO();

            //connect the list to the grid view control

            videoBindingSource.DataSource = videoDAO.getAllVideo_data(); 
            
            dataGridView1.DataSource = videoBindingSource;
        }
    }
}

