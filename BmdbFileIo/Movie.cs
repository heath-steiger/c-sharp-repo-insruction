namespace BmdbFileIo
{
    internal class Movie
    {

        public string ID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }


        public Movie(string ID, string title, string year, string rating, string director)
        {
            this.ID = ID;
            this.Title = title;
            this.Year = year;
            this.Rating = rating;
            this.Director = director;
            
        }

        public override string ToString()
        {
            return $"Movie: ({ ID}) - {Title} - {Year} - {Rating} - {Director:c}"; 
        }


    }
}
