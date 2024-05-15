/// <summary>
/// Хранит данные о песне.
/// </summary>
class Song
{
    /// <summary>
    /// Хранит данные о названии песни.
    /// </summary>
    private string _genreOfMusic;

    /// <summary>
    /// Хранит данные о длительности песни.
    /// </summary>
    private int _duration;

    /// <summary>
    /// Хранит данные о авторе песни.
    /// </summary>
    private string _artist;

    /// <summary>
    /// Хранит данные о дате выхода песни.
    /// </summary>
    private int _release;

    /// <summary>
    /// Возращает и задает жанр песни.
    /// </summary>
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

    /// <summary>
    /// Возращает и задает имя автора песни.
    /// </summary>
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

    /// <summary>
    /// Возращает и задает длительность песни.
    /// Задает через проверку при помощи класса <see cref="Validator"?/>. Длительность должна быть положительным числом.
    /// </summary>
    public int Duration
    {
        get { return _duration; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _duration = value;
        }
    }

    /// <summary>
    /// Возращает и задает дату выхода песни. 
    /// Задает через проверку при помощи класса <see cref="Validator"?/>. Дата должна быть числом от 1960 до 2025.
    /// </summary>
    public int Release
    {
        get { return _release; }
        set
        {
            Validator.AssertValueInRange(value, 1960, 2025);
            _release = value;
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Song"/>
    /// </summary>
    public Song()
    {
        GenreOfMusic = "Dance-Pop";
        Artist = "Rick Astley";
        Duration = 333;
        Release = 1987;
    }

    /// <summary>
    /// Экземпляр класса <see cref="Song"/>
    /// </summary>
    /// <param name="genreOfMusic">Жанр песни.</param>
    /// <param name="artist">Имя автора.</param>
    /// <param name="duration">Длительность песни.</param>
    /// <param name="release">Дата выхода песни.</param>
    public Song(string genreOfMusic, string artist, int duration, int release)
    {
        GenreOfMusic = genreOfMusic;
        Artist = artist;
        Duration = duration;
        Release = release;
    }
}