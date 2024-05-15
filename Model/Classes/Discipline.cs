using System.ComponentModel.DataAnnotations;

/// <summary>
/// Хранит данные о форме обучения.
/// </summary>
class Discipline
{
    /// <summary>
    /// Хранит данные о названии дисциплины.
    /// </summary>
    private string _disciplineName;

    /// <summary>
    /// Хранит данные об оценке за дисциплину.
    /// </summary>
    private int _grade;

    /// <summary>
    /// Хранит название о преподователе.
    /// </summary>
    private string _teacher;

    /// <summary>
    /// Хранит данные о семестре, в котором преподается этот предмет.
    /// </summary>
    private int _semester;

    /// <summary>
    /// Возращает и задает название дисциплины.
    /// </summary>
    public string DisciplineName
    {
        get { return _disciplineName; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _disciplineName = value;
        }
    }

    /// <summary>
    /// Возращает и задает оценку.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Оценка должна быть числом от 1 до 5.
    /// </summary>
    public int Grade
    {
        get { return _grade; }
        set
        {
            Validator.AssertValueInRange(value, 1, 5);
            _grade = value;
        }
    }

    /// <summary>
    /// Возращает и задает семестр.
    /// Задает через проверку при помощи класса <see cref="Validator"/>. Семестр должен быть числом от 1 до 8.
    /// </summary>
    public int Semester
    {
        get { return _semester; }
        set
        {
            Validator.AssertValueInRange(value, 1, 8);
            _semester = value;
        }
    }

    /// <summary>
    /// Возращает и задает имя преподавателя.
    /// </summary>
    public string Teacher
    {
        get { return _teacher; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _teacher = value;
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Discipline"/>
    /// </summary>
    public Discipline()
    {
        DisciplineName = "Programming";
        Grade = 5;
        Semester = 2;
        Teacher = "Goryainov Alexander";
    }

    /// <summary>
    /// Экземпляр класса <see cref="Discipline"/>
    /// </summary>
    /// <param name="disciplineName">Название дисциплины.</param>
    /// <param name="grade">Оценка.</param>
    /// <param name="semester">Семестр.</param>
    /// <param name="teacher">Преподаватель.</param>
    public Discipline(string disciplineName, int grade, int semester, string teacher)
    {
        DisciplineName = disciplineName;
        Grade = grade;
        Semester = semester;
        Teacher = teacher;
    }
}