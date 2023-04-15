using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLMSApp
{
    internal class VideoDAO
    {
        //VERSION 1 only contains dummy data. No relation to db yet.
        //public List<Video_data> video_data = new List<Video_data>();
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vlms;";

        public List<Video_data> getAllVideo_data()
        {
            List<Video_data> returnThese = new List<Video_data>();

            //sql connection

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define sql statement to fetch all video_data
            MySqlCommand command = new MySqlCommand("SELECT * FROM video_data", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Video_data v = new Video_data
                    {
                        video_id = reader.GetInt32(0),
                        title = reader.GetString(1),
                        director = reader.GetString(2),
                        release_year = reader.GetInt32(3),
                        genre = reader.GetString(4),
                        summary = reader.GetString(5),
                        actors = reader.GetString(6),
                        upload_datetime = reader.GetDateTime(7),
                        duration_minutes = reader.GetInt32(8),
                        cost_dollars = reader.GetInt32(9),
                        image_name = reader.GetString(10),

                    };
                    returnThese.Add(v);
                }
            }
            connection.Close();



            return returnThese;
        }

        public List<Video_data> searchTitles(string searchTerm)
        {
            List<Video_data> returnThese = new List<Video_data>();

            //sql connection

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            //define sql statement to fetch all video_data
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM video_data WHERE title LIKE @search";

            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Video_data v = new Video_data
                    {
                        video_id = reader.GetInt32(0),
                        title = reader.GetString(1),
                        director = reader.GetString(2),
                        release_year = reader.GetInt32(3),
                        genre = reader.GetString(4),
                        summary = reader.GetString(5),
                        actors = reader.GetString(6),
                        upload_datetime = reader.GetDateTime(7),
                        duration_minutes = reader.GetInt32(8),
                        cost_dollars = reader.GetDouble(9),
                        image_name = reader.GetString(10),

                    };
                    returnThese.Add(v);
                }
            }
            connection.Close();



            return returnThese;
        }

    }
}
