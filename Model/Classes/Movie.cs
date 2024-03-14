class Movie
{
    private string _nameOfMovie;
    private int _durationInMinutes;
    private int _yearOfRelease;
    private string _genreOfMovie;
    private double _rating;

    public string NameOfMovie
    {
        get { return _nameOfMovie; }
        set 
        {
            if (value.Length < 0)
            {
                throw new ArgumentException("Name is empty");
            }
            _nameOfMovie = value;
        }
    }
    public int DurationInMinutes
    {
        get { return _durationInMinutes; }
        set
        {
            if (value < 60) throw new ArgumentException();
            _durationInMinutes = value;
        }
    }
    public int YearOfRelease 
    {
        get { return _yearOfRelease; }
        set
        {
            if(value < 1900) throw new ArgumentException();
            _yearOfRelease = value;
        }
    }
    public Genre GenreOfMovie { get; set; }

    public double Rating
    {
        get { return _rating; }
        set
        {
            if(value < 1) throw new ArgumentException();
            _rating = value;
        }
    }
    public Movie()
    {
        NameOfMovie = "Drive";
        DurationInMinutes = 100;
        YearOfRelease = 2011;
        GenreOfMovie = Genre.Thriller;
        Rating = 8.3;
    }
    public Movie(string nameOfMovie, int durationInMinutes, int yearOfRelease, Genre genreOfMovie, double rating)
    {
        NameOfMovie = nameOfMovie;
        DurationInMinutes = durationInMinutes;
        YearOfRelease = yearOfRelease;
        GenreOfMovie = genreOfMovie;
        Rating = rating;
    }
}