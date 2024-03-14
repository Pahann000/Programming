using System.ComponentModel.DataAnnotations;

class Discipline
{
    private string _disciplineName;
    private int _grade;
    private string _teacher;
    private int _semester;
    public string DisciplineName
    {
        get { return _disciplineName; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _disciplineName = value;
        }
    }
    public int Grade
    {
        get { return _grade; }
        set
        {
            if(value > 5 && value < 1) throw new ArgumentException();
            _grade = value;
        }
    }
    public int Semester
    {
        get { return _semester; }
        set
        {
            if( value > 8 && value < 1)throw new ArgumentException();
            _semester = value;
        }
    }
    public string Teacher
    {
        get { return _teacher; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _teacher = value;
        }
    }

    public Discipline()
    {
        DisciplineName = "Programming";
        Grade = 5;
        Semester = 2;
        Teacher = "Goryainov Alexander";
    }

    public Discipline(string disciplineName, int grade, int semester, string teacher)
    {
        DisciplineName = disciplineName;
        Grade = grade;
        Semester = semester;
        Teacher = teacher;
    }
}