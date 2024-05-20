/// <summary>
/// 
/// </summary>
public class MyNotes
{
    /// <summary>
    /// 
    /// </summary>
    private string _noteTitle;

    /// <summary>
    /// 
    /// </summary>
    private string _noteText;

    /// <summary>
    /// 
    /// </summary>
    private DateTime _savingTime;

    /// <summary>
    /// 
    /// </summary>
    private NotesCategory _noteCategory;

    /// <summary>
    /// 
    /// </summary>
    public string NoteTitle
    {
        get { return _noteTitle; }
        set { NotesValidator.LengthValidator(0, 100, value); _noteTitle = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public string NoteText
    {
        get { return _noteText; }
        set { _noteText = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime SavingTime { get { return _savingTime; } set { _savingTime = value; } }


    /// <summary>
    /// 
    /// </summary>
    public NotesCategory NoteCategory { get { return _noteCategory; } set { _noteCategory = value; } }

    /// <summary>
    /// 
    /// </summary>
    public MyNotes()
    {
        
    }

    /// <summary>
    /// 
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

