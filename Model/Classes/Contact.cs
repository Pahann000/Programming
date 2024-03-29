using System.CodeDom;
using System.Text.RegularExpressions;

class Contact
{
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            AssertStringContainsOnlyLetters(value);
            _firstName = value;
        }
    }
    public string LastName
    {
        get { return _lastName; }
        set
        {
            AssertStringContainsOnlyLetters(value);
            _lastName = value;
        }
    }
    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if(value.Length < 0) throw new ArgumentException();
            _phoneNumber = value;
        }
    }
    private string AssertStringContainsOnlyLetters(string value)
    {
        if(Regex.IsMatch(value, @"^[a-zA-Z]+$"))
        {
            return value;
        }
        else { throw new ArgumentException($"{value} is not right. "); }
    }
    public Contact()
    {
        FirstName = "Alexey";
        LastName = "Khvorostyanoy";
        PhoneNumber = "89697771488";
    }
    public Contact(string firstName, string lastName, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }
}