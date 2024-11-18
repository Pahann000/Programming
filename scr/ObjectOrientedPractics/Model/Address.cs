using System.Reflection;

public class Address :  ICloneable, IEquatable<Address>
{
    /// <summary>
    /// Хранит в себе почтовый индекс.
    /// </summary>
    private int _index;

    /// <summary>
    /// Хранит в себе название страны.
    /// </summary>
    private string _country;

    /// <summary>
    /// Хранит в себе название города.
    /// </summary>
    private string _city;

    /// <summary>
    /// Хранит в себе название улицы.
    /// </summary>
    private string _street;

    /// <summary>
    /// Хранит в себе номер дома
    /// </summary>
    private string _building;

    /// <summary>
    /// Хранит в себе номер квартиры.
    /// </summary>
    private string _apartment;

    /// <summary>
    /// 
    /// </summary>
    public event EventHandler AddressChanged;

    /// <summary>
    /// Задает и возращает почтовый индекс.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>.
    /// Почтовый индекс должен быть шестизначный целым числом.
    /// </summary>
    public int Index
    {
        get { return _index; }
        set 
        {
            ValueValidator.AssertNumberInRange(value, 100000, 999999, nameof(Index));
            _index = value;
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Задает и возращает страну покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>.
    /// Название страны должно быть не более 50 символов в длину .
    /// </summary>
    public string Country
    {
        get { return _country; }
        set
        { 
            ValueValidator.AssertStringOnLength(value,  50, nameof(Country));
            _country = value;
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Задает и возращает город покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>.
    /// Название города должно быть не более 50 символов в длину .
    /// </summary>
    public string City
    {
        get { return _city; }
        set
        {
            ValueValidator.AssertStringOnLength(value,  50, nameof(City));
            _city = value;
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Задает и возращает улицу покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>.
    /// Название улицы должно быть не более 100 символов в длину .
    /// </summary>
    public string Street
    {
        get { return _street; }
        set
        {
            ValueValidator.AssertStringOnLength(value , 100, nameof(Street));
            _street = value;
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Задает и возращает номер дома покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>.
    /// Номер дома должнен быть не более 10 символов в длину .
    /// </summary>
    public string Building
    {
        get { return _building; }
        set 
        {
            ValueValidator.AssertStringOnLength(value,  10, nameof(Building));
            _building = value;
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Задает и возращает номер квартиры покупателя.
    /// Задает через проверку с помощью класса <see cref="ValueValidator"/>.
    /// Номер квартиры должнен быть не более 10 символов в длину .
    /// </summary>
    public string Apartment
    {
        get { return _apartment; }
        set
        {   
            ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
            _apartment = value;
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

    }

    /// <summary>
    /// Экземпляр класса <see cref="Address"/>
    /// </summary>
    public Address()
    {
        Index = 100001;
        Country = "Russia";
        City = "Tomsk";
        Street = "F. Lytkin st.";
        Building = "18";
        Apartment = "507";

    }

    /// <summary>
    /// Экземпляр класса <see cref="Address"/>
    /// </summary>
    /// <param name="index">Почтовый индекс покупателя.</param>
    /// <param name="country">Страна покупателя.</param>
    /// <param name="city">Город покупателя.</param>
    /// <param name="street">Улица покупателя.</param>
    /// <param name="building">Номер дома покупателя.</param>
    /// <param name="apartment">Номер квартиры покупателя.</param>
    public Address(int index, string country, string city, string street, string building, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }

    public object Clone()
    {
        return new Address(Index, Country, City, Street, Building, Apartment);
    }

    public bool Equals(Address? address2)
    {
        if (address2 == null)
            return false;
        if (object.ReferenceEquals(this, address2))
            return true;

        PropertyInfo[] properties = typeof(Address).GetProperties();

        foreach (PropertyInfo property in properties)
        {
            var value1 = property.GetValue(this);
            var value2 = property.GetValue(address2);

            if (value1 == null && value2 == null)
                continue;
            if (value1 == null || value2 == null || value1 != value2)
                return false; // Если одно из значений null или они не равны
        }

        return true;
    }
}