class Customer
{
    /// <summary>
    /// Хранит в себе порядковые номера клиентов.
    /// </summary>
    private static int _allCustomerCount;

    /// <summary>
    /// Хранит в себе уникальный номер покупателя. 
    /// </summary>
    readonly int _id;

    /// <summary>
    /// Хранит в себе полное ФИО покупателя.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// Хранит адрес покупателя.
    /// </summary>
    private string _address;

    /// <summary>
    /// Задает и возращает полное ФИО покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>. ФИО покупателя должно быть не более 200 символов в длину.
    /// </summary>
    public string FullName
    {
        get { return _fullName; }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
            _fullName = value;
        }
    }

    /// <summary>
    /// Возращает уникальный номер товара.
    /// </summary>
    public int Id { get { return _id; } }

    /// <summary>
    /// Задает и возращает адрес покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>. Адрес должен быть не более 500 символов в длину.
    /// </summary>
    public string Address
    {
        get { return _address; }
        set
        {
            ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
            _address = value;
        }
    }

    /// <summary>
    /// Хранит данные о количестве товаров.
    /// </summary>
    public static int AllCustomerCount { get { return _allCustomerCount; } }

    /// <summary>
    /// Экземпляр класса <see cref="Customer"/>.
    /// </summary>
    public Customer()
    {
        FullName = "Khvorostyanoy Alexey Sergeevich";
        Address = "Tomsk, F. Lytkin st. 18";
        _id = ++_allCustomerCount;
    }

    /// <summary>
    /// Экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullName">Полное ФИО. Должно быть не более 200 символов в длину.</param>
    /// <param name="address">Адрес покупателя. Должен быть не более 500 символов в длину.</param>
    public Customer(string fullName, string address)
    {
        FullName = fullName;
        Address = address;
        _id = ++_allCustomerCount;
    }
}