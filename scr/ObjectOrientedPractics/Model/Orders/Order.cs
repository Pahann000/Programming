/// <summary>
/// Хранит данные о заказе
/// </summary>
public class Order : IEquatable<Order>
{
    /// <summary>
    /// Уникальный id
    /// </summary>
    private int _id;

    /// <summary>
    /// Дата создания заказа
    /// </summary>
    private DateTime _date;

    /// <summary>
    /// Адрес доставки
    /// </summary>
    private Address _address;

    /// <summary>
    /// Список товаров
    /// </summary>
    private List<Item> _items = new List<Item> ();

    /// <summary>
    /// Общая цена товаров из списка
    /// </summary>
    private double _amount;

    private OrderStatus _status;

    /// <summary>
    /// Возвращает уникальный id
    /// </summary>
    public int Id { get; protected set; }

    /// <summary>
    /// Возвращает дату создания заказа
    /// </summary>
    public DateTime Date
    {
        get { return _date; }
        private set { _date = DateTime.Now; }
    }

    /// <summary>
    /// Возвращает и задаёт адрес доставки
    /// </summary>
    public Address Address { get { return _address; } set { _address = value; } }

    /// <summary>
    /// Возвращает и задаёт список товаров
    /// </summary>
    public List<Item> Items { get { return _items; } set { _items = value; } }

    /// <summary>
    /// Возвращает и задаёт общую цену товаров из списка
    /// </summary>
    public double Amount { get { return _amount; } set { _amount = value; } }

    /// <summary>
    /// Возращает и задает текущий статус заказа.
    /// </summary>
    public OrderStatus Status { get { return _status; } set { _status = value; } }

    /// <summary>
    /// Вощращает и задает сумму скидки.
    /// </summary>
    public double DiscountAmount { get; set; }

    /// <summary>
    /// Возращает и задает итоговую стоимость.
    /// </summary>
    public double Total { get; set; }

    /// <summary>
    /// Экземпляр класса <see cref="Order">
    /// </summary>
    /// <param name="address"> Адрес доставки.</param>
    /// <param name="amount">Стоимость заказа.</param>
    /// <param name="status">Статус заказа.</param>
    /// <param name="items">Список товаров.</param>
    public Order(Address address, double amount, OrderStatus status, List<Item> items)
    {
        Address =  address;
        Amount = amount;
        Status = status;
        Items = items;
        Date = DateTime.Now;
        Id = IdGenerator.GetNextId("Order");
    }

    /// <summary>
    /// Пустой экземпляр класса <see cref="Order"/>
    /// </summary>
    public Order()
    {
        
    }

    public bool Equals(Order? order2)
    {
        if (order2 == null)
            return false;
        if (object.ReferenceEquals(this, order2))
            return true;
        return (Id == order2.Id);
    }
}