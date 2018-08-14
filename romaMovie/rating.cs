using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace romaMovie
{
    class rating
    {
        static string cs = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + @"\DB.mdf;";

        private static void buildRatingDB(string path)
        {
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection(cs);
            con.Open();
            string qry;

            using (StreamReader sr = new StreamReader(path))
            {
                string currentLine;
                bool firstLine = true;
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }
                    string[] values = currentLine.Split(',');
                    qry = "INSERT INTO Rating (userId, movieId, rating) VALUES('" + values[0] + "', '" + values[1] + "', " + values[2] + ");";
                    cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            con.Close();
        }
        private static void buildMoviesDB(string pathMovies, string pathLinks)
        {
            Dictionary<string, string> moviesLinks = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(pathLinks))
            {
                string currentLine;
                bool firstLine = true;
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }
                    string[] values = currentLine.Split(',');
                    moviesLinks.Add(values[0], values[1]);
                }
            }

            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection(cs);
            con.Open();
            string qry;

            using (StreamReader sr = new StreamReader(pathMovies))
            {
                string currentLine;
                bool firstLine = true;
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }
                    currentLine = currentLine.Replace("'", "");
                    string[] values = currentLine.Split('\t');
                    string img_url = getUrl(moviesLinks[values[0]]);
                    qry = "INSERT INTO movies (movieId,name,url) VALUES('" + values[0] + "', '" + values[1] + "', '" + img_url + "');";
                    cmd = new SqlCommand(qry, con);
                    Console.WriteLine(qry);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            con.Close();
        }
        private static void buildTopMoviesDB()
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string qry = "select movieId ,name,url from movies where movieId= any(select top 100 movieId from Rating group by movieId order by avg(rating) DESC);";
            con = new SqlConnection(cs);
            con.Open();
            cmd = new SqlCommand(qry, con);
            dataReader = cmd.ExecuteReader();

            List<Movie> movies = new List<Movie>();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    movies.Add(new Movie((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2)));
                }
            }

            dataReader.Close();
            cmd.Dispose();
            con.Close();

            con = new SqlConnection(cs);
            con.Open();
            foreach (Movie item in movies)
            {
                try
                {
                    qry = "INSERT INTO TopMovies (movieId,name,url) VALUES('" + item.id + "', '" + item.name + "', '" + item.url + "');";
                    cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception)
                {
                    cmd.Dispose();
                }
                
            }
            cmd.Dispose();
            con.Close();

        }

        public static List<Movie> getTopMovies(int x)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string qry = "select movieId ,name,url from TopMovies;";
            con = new SqlConnection(cs);
            con.Open();
            cmd = new SqlCommand(qry, con);
            dataReader = cmd.ExecuteReader();

            List<Movie> movies = new List<Movie>();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    movies.Add(new Movie((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2)));
                }
            }

            dataReader.Close();
            cmd.Dispose();
            con.Close();

            Random r = new Random();
            List<Movie> movies2 = new List<Movie>();
            for (int i = 0; i < Math.Min(x, movies.Count) ; i++)
            {
                int tmp = r.Next(0, movies.Count);
                movies2.Add(movies[tmp]);
                movies.RemoveAt(tmp);                    
            }

            return movies2;
        }

        public static Dictionary<string, double> getMoviesPerUser(string userId)
        {

            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string qry = "select movieId,rating from Rating where userId= " + userId + ";";
            con = new SqlConnection(cs);

            con.Open();
            cmd = new SqlCommand(qry, con);
            dataReader = cmd.ExecuteReader();

            Dictionary<string, double> ans = new Dictionary<string, double>();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                    ans.Add((string)dataReader.GetValue(0), (double)dataReader.GetValue(1));
            }

            dataReader.Close();
            cmd.Dispose();
            con.Close();

            return ans;
        }

        public static List<string> getAllUsers()
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string qry = "select userId from Rating group by userId;";
            con = new SqlConnection(cs);

            con.Open();
            cmd = new SqlCommand(qry, con);
            dataReader = cmd.ExecuteReader();

            List<string> ans = new List<string>();
            if (dataReader.HasRows)
                while (dataReader.Read())
                    ans.Add((string)dataReader.GetValue(0));
                
            dataReader.Close();
            cmd.Dispose();
            con.Close();

            return ans;
        }

        public static List<Movie> getTopMoviePerUser(string userId, int x)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string qry = "select movieId ,name,url from movies where  movieId= any(select top "+x+" movieId from Rating where userId="+userId+" group by movieId order by avg(rating) DESC);";
            con = new SqlConnection(cs);

            con.Open();
            cmd = new SqlCommand(qry, con);
            dataReader = cmd.ExecuteReader();

            List<Movie> movies = new List<Movie>();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    movies.Add(new Movie((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2)));
                }
            }

            dataReader.Close();
            cmd.Dispose();
            con.Close();

            return movies;
        }

        public static Movie getMovieById(string movieId)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string qry = "select * from movies where movieId="+ movieId + ";";
            con = new SqlConnection(cs);

            con.Open();
            cmd = new SqlCommand(qry, con);
            dataReader = cmd.ExecuteReader();

            Movie movie = null;
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    movie=new Movie((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2));
                }
            }

            dataReader.Close();
            cmd.Dispose();
            con.Close();

            return movie;
        }

        private static string getUrl(string num)
        {
            if (num.Length < 7)
            {
                int zeros = 7 - num.Length;
                for (int i = 0; i < zeros; i++)
                    num = "0" + num;
            }
            num = "tt" + num;
            return num;
        }
    }
}
