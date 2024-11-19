using System.Reflection.Metadata.Ecma335;

public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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
    /// Событие изменения названия.
    /// </summary>
    public event EventHandler NameChanged;

    /// <summary>
    /// Событие изменения информации.
    /// </summary>
    public event EventHandler InfoChanged;

    /// <summary>
    /// Событие изменения стоимости.
    /// </summary>
    public event EventHandler PriceChanged;

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
            NameChanged?.Invoke(this, EventArgs.Empty);
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
            NameChanged?.Invoke(this, EventArgs.Empty);
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
            PriceChanged?.Invoke(this, EventArgs.Empty);
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

    public object Clone()
    {
        return new Item(Name, Info, Price, Category);
    }

    /// <inheritdoc/>
    public bool Equals(Item? item2)
    {
        if (item2 == null)
            return false;
        if (object.ReferenceEquals(this, item2))
            return true;
        return (Id == item2.Id);
    }

    public int CompareTo(Item? item2)
    {
        if (item2 == null)
            return 1;
        if (object.ReferenceEquals(this, item2))
            return 0;

        if (Price < item2.Price)
        {
            return -1;
        }
        else if (Price == item2.Price)
        {
            return 0;
        }
        return 1;
    }

}