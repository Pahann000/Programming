public class Item
{
    /// <summary>
    /// Хранит в себе название товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Хранит в себе информацию о товаре.
    /// </summary>
    private string _info;

    /// <summary>
    /// Хранит в себе цену товара.
    /// </summary>
    private double _price;

    /// <summary>
    /// Возращает уникальный номер товара.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Возращает и задает название товара.
    /// Задает через проверку при помощи класса <see cref="ValueValidator"/>. Значение должно быть не более 200.
    /// </summary>
    public string Name
    {
        get { return _name; }
        set {
            ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Name));
            ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
            _name = value;
            }
    }

    /// <summary>
    /// Возращает и задает информацию о товаре.
    /// Задает через проверку при помощи класса <see cref="ValueValidator"/>. Значение должно быть не больше 1000.
    /// </summary>
    public string Info
    {
        get { return _info; }
        set
        {
            ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Info));
            ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
            _info = value;
        }
    }

    /// <summary>
    /// Возращает и задает цену товара.
    /// Задает через проверку при помощи класса <see cref="ValueValidator"/>. Значение должно быть в диапазоне от 0 до 100000.
    /// </summary>
    public double Price
    {
        get { return _price; }
        set
        {
            ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Price));
            ValueValidator.AssertNumberInRange(value, 0, 100000, nameof(Price));
            _price = value;
        }
    }

    /// <summary>
    /// Задает категорию товара.
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Создает экземпляр класса <see cref="Item"/>.
    /// </summary>
    public Item()
    {
        Name = "Milk";
        Info = "Used by people to cooking";
        Price = 89.99;
        Id = IdGenerator.GetNextId("Item");

    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Item"/>.
    /// </summary>
    /// <param name="name">Имя товара. Должно быть не длиннее 200 символов.</param>
    /// <param name="info">Информация о товаре. Должна быть не длиннее 1000 символов.</param>
    /// <param name="price">Цена товара. Должна быть в диапазоне от 0 до 100000.</param>
    /// <param name="category">Категория товара.</param>
    public Item( string name, string info, double price, Category category)
    {
        Name = name;
        Info = info;
        Price = price;
        Category = category;
        Id = IdGenerator.GetNextId("Item");
    }

}