/// <summary>
/// Хранит данные о заметках.
/// </summary>
public class MyNotes
{
    /// <summary>
    /// Хранит название.
    /// </summary>
    private string _noteTitle;

    /// <summary>
    /// Хранит содержание.
    /// </summary>
    private string _noteText;

    /// <summary>
    /// Хранит время создания.
    /// </summary>
    private DateTime _savingTime;

    /// <summary>
    /// Хранит категорию.
    /// </summary>
    private NotesCategory _noteCategory;

    /// <summary>
    /// Возращает и записывает название. 
    /// Проходит проверку с помощью класса <see cref="NotesValidator"/ Текст должен быть не больше 100 символов.>
    /// </summary>
    public string NoteTitle
    {
        get { return _noteTitle; }
        set { NotesValidator.LengthValidator(0, 100, value); _noteTitle = value; }
    }

    /// <summary>
    /// Возращает и записывает содержание заметки.
    /// </summary>
    public string NoteText
    {
        get { return _noteText; }
        set { _noteText = value; }
    }

    /// <summary>
    /// Возращает и записывает время создания.
    /// </summary>
    public DateTime SavingTime { get; set; }


    /// <summary>
    /// Возращает и записывает категорию.
    /// </summary>
    public NotesCategory NoteCategory { get { return _noteCategory; } set { _noteCategory = value; } }

    /// <summary>
    /// Пустой экзепляр класса <see cref="MyNotes"/>
    /// </summary>
    public MyNotes()
    {
        
    }

    /// <summary>
    /// Экземпляр класса <see cref="MyNotes"/>
    /// </summary>
    /// <param name="noteTitle"></param>
    /// <param name="noteText"></param>
    /// <param name="savedTime"></param>
    /// <param name="noteCategories"></param>
    public MyNotes(string noteTitle, string noteText, DateTime savedTime, NotesCategory noteCategories)
    {
        _noteTitle = noteTitle;
        _noteText = noteText;
        _savingTime = savedTime;
        _noteCategory = noteCategories;
    }



}

