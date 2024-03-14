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
            if (value.Length < 0) throw new ArgumentException();
            _firstName = value;
        }
    }
    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (value.Length < 0) throw new ArgumentException();
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