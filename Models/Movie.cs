namespace matala1y3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
        public double Income { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string PhotoUrl { get; set; }

        public static List<Movie> MoviesList = new List<Movie>();

        public bool Insert(Movie m)
        {
            for (int i = 0; i < MoviesList.Count; i++)
            {
                if (m.Id == MoviesList[i].Id)
                    return false;
            }
            MoviesList.Add(m);
            return true;
        }
        public static List<Movie> Read()
        {
            return MoviesList;
        }
        public  List<Movie> ReadByRating(double rating)
        {
            List<Movie> result = new List<Movie>();

            foreach (Movie m in MoviesList)
            {
                if (m.Rating >= rating)
                    result.Add(m);
            }
            return result;
        }

        public List<Movie> ReadByDuration(double duration)
        {
            List<Movie> result = new List<Movie>();

            foreach (Movie m in MoviesList)
            {
                if (m.Duration >= duration)
                    result.Add(m);
            }
            return result;
        }
    }
}

