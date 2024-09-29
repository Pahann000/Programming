public class Customer
{
    /// <summary>
    /// Хранит в себе полное ФИО покупателя.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// Хранит адрес покупателя.
    /// </summary>
    private Address _address;

    /// <summary>
    /// Задает и возращает полное ФИО покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>. ФИО покупателя должно быть не более 200 символов в длину.
    /// </summary>
    public string FullName
    {
        get { return _fullName; }
        set
        {
            ValueValidator.CheckStringOnNullOrEmpty(value, nameof(FullName));
            ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
            _fullName = value;
        }
    }

    /// <summary>
    /// Возращает уникальный номер товара.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Задает и возращает адрес покупателя.
    /// </summary>
    public Address Address
    {
        get { return _address; }
        set
        {
            _address = value;
        }
    }

    /// <summary>
    /// Экземпляр класса <see cref="Customer"/>.
    /// </summary>
    public Customer()
    {
        FullName = "Khvorostyanoy Alexey Sergeevich";
        Address = new Address();
        Id = IdGenerator.GetNextId("Customer");
    }

    /// <summary>
    /// Экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullName">Полное ФИО. Должно быть не более 200 символов в длину.</param>
    /// <param name="address">Адрес покупателя. Должен быть не более 500 символов в длину.</param>
    public Customer(string fullName, Address address)
    {
        FullName = fullName;
        Address = address;
        Id = IdGenerator.GetNextId("Customer");
    }
}