/// <summary>
/// Хранит данные о фильме.
/// </summary>
class Movie
{
    /// <summary>
    /// Хранит данные о названии фильма.
    /// </summary>
    private string _name;

    /// <summary>
    /// Хранит данные о длительности фильма.
    /// </summary>
    private int _duration;

    /// <summary>
    /// Хранит данные о годе выхода фильма.
    /// </summary>
    private int _yearOfRelease;

    /// <summary>
    /// Хранит данные о рейтинге фильма.
    /// </summary>
    private double _rating;

    /// <summary>
    /// Возращает и задает название фильма.
    /// </summary>
    public string Name
    {
        get { return _name; }
        set 
        {
            if (value.Length == 0) throw new ArgumentException();
            _name = value;
        }
    }

    /// <summary>
    /// Возращает и задает длительность фильма.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Длительность фильма должна быть положительным числом.
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
    /// Возращает и задает год выхода фильма.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Год выхода должен быть числом от 1900 до 2025.
    /// </summary>
    public int YearOfRelease 
    {
        get { return _yearOfRelease; }
        set
        {
            Validator.AssertValueInRange(value, 1900, 2025);
            _yearOfRelease = value;
        }
    }

    /// <summary>
    /// Возращает и задает жанр фильма.
    /// </summary>
    public Genre GenreOfMovie { get; set; }

    /// <summary>
    /// Возращает и задает рейтинг фильма. 
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Рейтинг должен быть числом от 1 до 10.
    /// </summary>
    public double Rating
    {
        get { return _rating; }
        set
        {
            Validator.AssertValueInRange(value, 0, 10);
            _rating = value;
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Movie"/>
    /// </summary>
    public Movie()
    {
        Name = "Drive";
        Duration = 100;
        YearOfRelease = 2011;
        Rating = 10;
    }

    /// <summary>
    /// Экземпляр класса <see cref="Movie"/>
    /// </summary>
    /// <param name="name">Название фильма.</param>
    /// <param name="duration">Длительность фильма.</param>
    /// <param name="yearOfRelease">Год выхода фильма.</param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма.</param>
    public Movie(string name, int duration, int yearOfRelease, Genre genre, double rating)
    {
        Name = name;
        Duration = duration;
        YearOfRelease = yearOfRelease;
        GenreOfMovie = genre;
        Rating = rating;
    }
}