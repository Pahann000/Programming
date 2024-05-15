using System.CodeDom;
using System.Text.RegularExpressions;

/// <summary>
/// Хранит данные о контактах человека.
/// </summary>
class Contact
{
    /// <summary>
    /// Хранит данные о имени человека.
    /// </summary>
    private string _firstName;

    /// <summary>
    /// Хранит данные о фамилии человека.
    /// </summary>
    private string _lastName;

    /// <summary>
    /// Хранит данные о номере человека.
    /// </summary>
    private string _phoneNumber;

    /// <summary>
    /// Возвращает и задает имя человека.
    /// Задает через проверку при помощи  <see cref="AssertStringContainsOnlyLetters"/>. Имя должно содержать символы латиницы.
    /// </summary>
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            AssertStringContainsOnlyLetters(value);
            _firstName = value;
        }
    }

    /// <summary>
    /// Возвращает и задает фамилию человека.
    /// Задает через проверку при помощи  <see cref="AssertStringContainsOnlyLetters"/>. Фамилия должна содержать символы латиницы.
    /// </summary>
    public string LastName
    {
        get { return _lastName; }
        set
        {
            AssertStringContainsOnlyLetters(value);
            _lastName = value;
        }
    }

    /// <summary>
    /// Возвращает и задает номер телефона человека.
    /// </summary>
    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if(value.Length < 0) throw new ArgumentException();
            _phoneNumber = value;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value">Имя человека</param>
    /// <returns>Возращает значение, если проверка на символы пройдена</returns>
    /// <exception cref="ArgumentException"></exception>
    private string AssertStringContainsOnlyLetters(string value)
    {
        if(Regex.IsMatch(value, @"^[a-zA-Z]+$"))
        {
            return value;
        }
        else { throw new ArgumentException($"{value} is not right. "); }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Contact"/>
    /// </summary>
    public Contact()
    {
        FirstName = "Alexey";
        LastName = "Khvorostyanoy";
        PhoneNumber = "89697771488";
    }

    /// <summary>
    /// Экземпляр класса <see cref="Contact"/>
    /// </summary>
    /// <param name="firstName">Имя человека. Должно быть только буквами.</param>
    /// <param name="lastName">Фамилия человека. Должно быть только буквами.</param>
    /// <param name="phoneNumber">Телефонный номер человека. </param>
    public Contact(string firstName, string lastName, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }
}