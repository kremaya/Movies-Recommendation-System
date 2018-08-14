using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romaMovie
{
    class Logic
    {
        
        private double avgURank;
        private Dictionary<string, double> userCorrelation;
        public Logic()
        {
            userCorrelation = new Dictionary<string, double>();
            
        }


        //MAIN FUNCTION RETURNS TO THE UI CLASS <movieID, rank> (cast to float please)
        public List<Movie> getMovies(Dictionary<string, double> userRanks)
        {
            avgURank = getAverageRating(userRanks);
            List<string> userList = rating.getAllUsers(); //REMOVE COMMENTS AFTER ADDING rating CLASS
            List<string> xWatchMovies = userRanks.Keys.ToList();

            //storing the top falmiliar users on top according to pearson calculation
            //SortedDictionary<double, string> pearsonedUsers = new SortedDictionary<double, string>(Comparer<double>.Create((x,y)=>y.CompareTo(x)));
            List<KeyValuePair<string, double>> pearsonedUsers = new List<KeyValuePair<string, double>>();



            foreach (string user in userList)
            {
                Dictionary<string, double> yMovies = rating.getMoviesPerUser(user);
                double avgY = getAverageRating(yMovies);

                //get movies that both users have rated
                List<string> shardeMovies = getSharedMovies(xWatchMovies, rating.getMoviesPerUser(user).Keys.ToList());

                //calculating Pearsom
                double pearsonRating = pearsonCalc(userRanks, yMovies, avgURank, avgY, shardeMovies);

                //pearsonedUsers.Add(pearsonRating, user);
                pearsonedUsers.Add(new KeyValuePair<string, double>(user, pearsonRating));
            }

            //from the top 3 users take the top 3 movies from each users CHANGE AS YOU WISH
            //List<string> recommend = new List<string>();
            //for (int i = 0; i < 3; i++)
            //{
            //    KeyValuePair<double,string> u = pearsonedUsers.ElementAt(i);
            //    recommend.AddRange(rating.getTopMoviePerUser(u.Value, 3));

            //}
            pearsonedUsers.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            List<Movie> recommend = new List<Movie>();
            for (int i = 0; i < 10; i++)
            {
                //KeyValuePair<double, string> u = pearsonedUsers.ElementAt(i);
                KeyValuePair<string, double> u = pearsonedUsers[i];

                //Feel free to change the number 5 to any number you wish for.
                recommend.AddRange(rating.getTopMoviePerUser(u.Key, 5));

                RemoveDupMovies(recommend);
                if (recommend.Count >= 40)
                    break;
            }
            //return only the 40 movies
            return recommend.GetRange(0,40);

        }

        private void RemoveDupMovies(List<Movie> MovList) => MovList = MovList.Distinct().ToList();


        //return x movies for the user to rank
        //public List<string> getMoviesForRank(int x)
        //{           
        //    return rating.getPopularMovies(x);
        //}

        //public string getMovieName(string movieId)
        //{
        //    int bla;
        //    if (int.TryParse(movieId, out bla))
        //        return rating.getMovieName(movieId);
        //    return null;
        //}

        //public string getMovieUrl(string movieId)
        //{
        //    int bla;
        //    if (int.TryParse(movieId, out bla))
        //        return rating.getMovieURL(movieId);
        //    return null;
        //}

        //calculate pearson correlation between user x and user y 
        //x and y should be sorted and x[i] == y[i]
        //the arreys only contains movies both x and y watched
        private double pearsonCalc(Dictionary<string, double> xMovies, Dictionary<string, double> yMovies, double _xAverage,double _yAverage, List<string> shared)
        {
            
            double up=0;
            double _1down = 0;
            double _2down = 0;
            foreach(string sharedMov in shared)
            {
                up += (xMovies[sharedMov] - _xAverage) * (yMovies[sharedMov] - _yAverage);
                _1down += Math.Pow(xMovies[sharedMov] - _xAverage, 2);
                _2down += Math.Pow(yMovies[sharedMov] - _yAverage, 2);
            }
            //Correlation = up/(_1down*_2down)
            //for (int i = 0; i <x.Length; i++)
            //{
            //    up+=(x[i] - _xAvegrage)*(y[i] - _yAverage);
            //    _1down += Math.Pow(x[i] - _xAvegrage, 2.0);
            //    _2down += Math.Pow(y[i] - _yAverage, 2.0);
            //}
            _1down = Math.Sqrt(_1down);
            _2down = Math.Sqrt(_2down);
            
            
            return up / (_1down * _2down);
        }

        //return average rating for the current user <movies, rating>
        private double getAverageRating(Dictionary<string,double> userRanks)
        {
            double sum = 0;
            double count = 0;
            //for (int i = 0; i < userRanks.Count; i++)
            //{
            //    if (userRanks[i].Item2 != 0)
            //    {
            //        count++;
            //        sum += userRanks[i].Item2;
            //    }
            //}
            foreach(KeyValuePair<string,double> rate in userRanks)
            {
                sum += rate.Value;
                count++;
            }
            if (count == 0)
                return -1;
            else
                return sum / count;
        }

        //return average rating for a specific users
        private double getAverageRating(int uID)
        {
            //Tuple<int,int>[] userRating = db.getUserRatings(uID);


            Dictionary<string, double> userRating = rating.getMoviesPerUser(uID.ToString());//REMOVE COMMENTS AFTER ADDING rating CLASS

            return getAverageRating(userRating);
        }

        private List<string> getSharedMovies(List<string> xMovies, List<string> yMovies)
        {
            List<string> shared = new List<string>();
            foreach(string movie in xMovies)
            {
                if (yMovies.Contains(movie))
                    shared.Add(movie);
            }
            return shared;
            //throw new NotImplementedException();
        }

    
    }
}
