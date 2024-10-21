/// <summary>
/// Хранит данные о корзине товаров покупателя.
/// </summary>
public class Cart
{
    /// <summary>
    /// Хранит в себе список товаров.
    /// </summary>
    private List<Item> _items = new List<Item>();


    /// <summary>
    /// Возращает и задает список товаров
    /// </summary>
    public List<Item> Items
    {
        get { return _items; }
        set { _items = value; }
    }

    /// <summary>
    /// Возращает и задает общую стоимость товаров
    /// </summary>
    public double Amount
    {
        get 
        {
            if (_items == null || _items.Count == 0)
                return 0.0;

            double totalCost = 0.0;
            for (int i = 0; i < _items.Count; i++)
            {
                totalCost += _items[i].Price;
            }
            return totalCost;
        }
    }
}