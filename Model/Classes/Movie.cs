class Movie
{
    private string _name;
    private int _duration;
    private int _yearOfRelease;
    private int _rating;

    public string Name
    {
        get { return _name; }
        set 
        {
            if (value.Length == 0) throw new ArgumentException();
            _name = value;
        }
    }
    public int Duration
    {
        get { return _duration; }
        set
        {
            if (value == 0) throw new ArgumentException();
            _duration = value;
        }
    }
    public int YearOfRelease 
    {
        get { return _yearOfRelease; }
        set
        {
            if (value < 1900 || value > 2025) throw new ArgumentException();
            _yearOfRelease = value;
        }
    }
    public Genre GenreOfMovie { get; set; }

    public int Rating
    {
        get { return _rating; }
        set
        {
            if(value < 0 || value > 10) throw new ArgumentException();
            _rating = value;
        }
    }
    public Movie()
    {
        Name = "Drive";
        Duration = 100;
        YearOfRelease = 2011;
        Rating = 10;
    }
    public Movie(string name, int duration, int yearOfRelease, Genre genre, int rating)
    {
        Name = name;
        Duration = duration;
        YearOfRelease = yearOfRelease;
        GenreOfMovie = genre;
        Rating = rating;
    }
}