class Customer
{
    /// <summary>
    /// Хранит в себе уникальный номер покупателя. 
    /// </summary>
    static int id = 0;

    /// <summary>
    /// Хранит в себе полное ФИО покупателя.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// Хранит адрес покупателя.
    /// </summary>
    private string _address;

    /// <summary>
    /// Задает уникальный номер покупателя.
    /// </summary>
    public static int Id => id;

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
        }
    }

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
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Customer"/>.
    /// </summary>
    public Customer()
    {
        FullName = "Khvorostyanoy Alexey Sergeevich";
        Address = "Tomsk, F. Lytkin st. 18";
        id++;
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
        id++;
    }
}