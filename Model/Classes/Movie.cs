class Movie
{
    private string _name;
    private int _duration;
    private int _yearOfRelease;
    private double _rating;

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
            Validator.AssertOnPositiveValue(value);
            _duration = value;
        }
    }
    public int YearOfRelease 
    {
        get { return _yearOfRelease; }
        set
        {
            Validator.AssertValueInRange(value, 1900, 2025);
            _yearOfRelease = value;
        }
    }
    public Genre GenreOfMovie { get; set; }

    public double Rating
    {
        get { return _rating; }
        set
        {
            Validator.AssertValueInRange(value, 0, 10);
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
    public Movie(string name, int duration, int yearOfRelease, Genre genre, double rating)
    {
        Name = name;
        Duration = duration;
        YearOfRelease = yearOfRelease;
        GenreOfMovie = genre;
        Rating = rating;
    }
}