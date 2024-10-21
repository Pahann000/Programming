public class IdGenerator
{
    /// <summary>
    /// Счётчик для Item
    /// </summary>
    private static int _counterItem;
    /// <summary>
    /// Счётчик для Customer
    /// </summary>
    private static int _counterCustomer;

    private static int _counterOrder;

    /// /// <summary>
    /// Возвращает уникальный Id
    /// </summary>
    /// <param name="choice">Строка с выбором (Item или Customer)</param>
    /// <returns>Уникальный Id</returns>
    public static int GetNextId(string choice)
    {
        switch (choice)
        {
            case ("Item"):
                return ++_counterItem;
            case ("Customer"):
                return ++_counterCustomer;
            case ("Order"):
                return ++_counterOrder;
        }
        return -1;
    }

}