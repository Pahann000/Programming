/// <summary>
/// Класс для заполнения таблицы данными
/// </summary>
public class OrdersFullData 
{
    public string Id { get; set; }
    public string Date { get; set; }
    public string FullName { get; set; }
    public Address Address { get; set; }
    public string Amount { get; set; }
    public string Status { get; set; }
    public Order Order { get; set; }
}
