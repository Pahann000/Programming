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
    /// Хранит корзину покупателя
    /// </summary>
    private Cart _cart;

    /// <summary>
    /// Хранит в себе список заказов.
    /// </summary>
    private List<Order> _order = new List<Order>();

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
            ValueValidator.AssertStringOnLength(value,  200, nameof(FullName));
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
    /// Возращает и задает корзину покупателя.
    /// </summary>
    public Cart Cart
    {
        get { return _cart; }
        set { _cart = value; }
    }

    /// <summary>
    /// Задает и возращает список заказов.
    /// </summary>
    public List<Order> Order
    {
        get { return _order; }
        set { _order = value; }
    }


    /// <summary>
    /// Экземпляр класса <see cref="Customer"/>.
    /// </summary>
    public Customer()
    {
        FullName = "Khvorostyanoy Alexey Sergeevich";
        Address = new Address();
        Cart = new Cart();
        Order = new List<Order>();
        Id = IdGenerator.GetNextId("Customer");
    }

    /// <summary>
    /// Экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullName">Полное ФИО. Должно быть не более 200 символов в длину.</param>
    /// <param name="address">Адрес покупателя. Должен быть не более 500 символов в длину.</param>
    public Customer(string fullName, Address address, Cart cart)
    {
        FullName = fullName;
        Address = address;
        Cart = cart;
        Id = IdGenerator.GetNextId("Customer");
    }
}