/// <summary>
/// Представляет приоритетный заказ, который наследует от базового класса Order.
/// </summary>
public class PriorityOrder : Order
{
    /// <summary>
    /// Дата заказа.
    /// </summary>
    private DateTime _date;

    /// <summary>
    /// Временной интервал для заказа.
    /// </summary>
    private string _orderTime;

    /// <summary>
    /// Список доступных временных интервалов для заказов.
    /// </summary>
    private static List<string> _orderTimes = new List<string>()
    {
        "9:00-11:00",
        "11:00-13:00",
        "13:00-15:00",
        "15:00-17:00",
        "17:00-19:00",
        "19:00-21:00"
    };

    /// <summary>
    /// Получает или задает дату заказа.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Получает или задает временной интервал для заказа.
    /// Разрешает только значения, которые находятся в предопределенном списке временных интервалов.
    /// </summary>
    public string OrderTime
    {
        get { return _orderTime; }
        set
        {
            if (!_orderTimes.Contains(value)) return;
            _orderTime = value;
        }
    }

    /// <summary>
    /// Получает список доступных временных интервалов для заказов.
    /// </summary>
    public static List<string> OrderTimes
    {
        get { return _orderTimes; }
    }

    /// <summary>
    /// Экземпляр класса <see cref="PriorityOrder"/> с заданными параметрами.
    /// </summary>
    /// <param name="address">Адрес для заказа.</param>
    /// <param name="amount">Общая сумма заказа.</param>
    /// <param name="status">Статус заказа.</param>
    /// <param name="items">Список товаров в заказе.</param>
    /// <param name="date">Дата заказа.</param>
    /// <param name="orderTime">Временной интервал для заказа.</param>
    public PriorityOrder(Address address, double amount, OrderStatus status, List<Item> items, DateTime date, string orderTime)
        : base(address, amount, status, items)
    {
        Date = date;
        OrderTime = orderTime;
    }

    /// <summary>
    /// Экземпляр класса <see cref="PriorityOrder"/> со значениями по умолчанию.
    /// </summary>
    public PriorityOrder()
    {

    }
}
