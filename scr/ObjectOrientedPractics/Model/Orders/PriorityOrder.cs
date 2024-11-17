public class PriorityOrder : Order
{
    private DateTime _date;

    private string _orderTime;

    public DateTime Date { get; set; }

    private static List<string> _orderTimes = new List<string>() { "9:00-11:00", "11:00-13:00", "13:00-15:00", "15:00-17:00", "17:00-19:00", "19:00-21:00" };
    public string OrderTime
    {
        get { return _orderTime; }
        set
        {
            if (!_orderTimes.Contains(value)) return;
            _orderTime = value;
        }
    }

    public static List<string> OrderTimes 
    {
        get { return _orderTimes; }
    }


    public PriorityOrder(Address address, double amount, OrderStatus status, List<Item> items, DateTime date, string orderTime)
        : base(address, amount, status, items)
    {
        Date = date;
        OrderTime = orderTime;
  
    }

    public PriorityOrder()
    {
        
    }

}