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
            Video_data v1 = new Video_data
            {
                video_id = 1,
                title = "Avengers",
                director = "Russo Brothers",
                release_year = 2019,
                genre = "Action",
                summary = "Blah blah blah",
                actors = "Robert Downey Jr.",
                upload_datetime = new DateTime(1974, 7, 10, 7, 10, 24),
                duration_minutes = 189,
                cost_dollars = 14.99,
                image_name = "Blah_blah_blah"
            };
            Video_data v2 = new Video_data
            {
                video_id = 2,
                title = "Revenger",
                director = "Russo Brothers",
                release_year = 2019,
                genre = "Action",
                summary = "Blah blah blah",
                actors = "Robert Downey Jr.",
                upload_datetime = new DateTime(1975, 7, 10, 7, 10, 24),
                duration_minutes = 149,
                cost_dollars = 15.99,
                image_name = "Blah_blah_blah"
            };

            videoDAO.video_data.Add(v1);
            videoDAO.video_data.Add(v2);

            //connect the list to the grid view control

            videoBindingSource.DataSource = videoDAO.video_data; 
            
            dataGridView1.DataSource = videoBindingSource;
        }
    }
}

