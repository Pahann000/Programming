class Song
{
    private string _genreOfMusic;
    private int _duration;
    private string _artist;
    private int _release;

    public string GenreOfMusic
    {
        get { return _genreOfMusic; }
        set
        {
            if (value.Length < 0)
            {
                throw new ArgumentException("Genre is empty");
            }
            _genreOfMusic = value;
        }
    }
    public string Artist
    {
        get { return _artist; }
        set
        {
            if (value.Length < 0)
            {
                throw new ArgumentException("Name of artist is empty!");
            }
            _artist = value;
        }
    }

    public int Duration
    {
        get { return _duration; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("The duration cannot be less than 1 minute");
            }
            _duration = value;
        }
    }

    public int Release
    {
        get { return _release; }
        set
        {
            if (value < 1960)
            {
                throw new ArgumentException("There were no players before 1960!");
            }
            _release = value;
        }
    }

    public Song()
    {
        GenreOfMusic = "Dance-Pop";
        Artist = "Rick Astley";
        Duration = 333;
        Release = 1987;
    }

    public Song(string genreOfMusic, string artist, int duration, int release)
    {
        GenreOfMusic = genreOfMusic;
        Artist = artist;
        Duration = duration;
        Release = release;
    }
}