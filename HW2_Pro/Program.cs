public class Money
{
    private int _integerPart;
    private int _coinPart;
    public int IntegerPart
    {
        get
        {
            return _integerPart;
        }
        set
        {
            if (value > 0)
            {
                _integerPart = value;
            }
           
        }
    }
    public int coinPart
    {
        get
        {
            return _coinPart;
        }
        set
        {
            if(value > 0)
            {
                _coinPart = value;
            }
        }
    }
    public void ShowSum()
    {
        Console.WriteLine($"You set: {_integerPart} grn {_coinPart} coins");
    }
    public void SetSum(int integerPart, int coinPart)
    {
        _integerPart = integerPart;
        _coinPart = coinPart;
        while(_coinPart > 100)
        {
           Console.WriteLine("Enter correct coin value(0-100)");
           _coinPart = Convert.ToInt32( Console.ReadLine() );
        }
    }
}

public class Product
{
    public string Name { get; set; } = string.Empty;
    public Money? MoneySum { get; set; }

    public void ShowProduct()
    {
        Console.WriteLine($"Product: {Name} and Price: {MoneySum?.IntegerPart} grn {MoneySum?.coinPart} coins");
    }
}

class Program
{
     public static void Main(string[] args)
    {
        Console.WriteLine("Enter integer part: ");
        int integerPart = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coin part: ");
        int coinPart = Convert.ToInt32(Console.ReadLine());
        var money = new Money();
        money.SetSum(integerPart, coinPart);
        money.ShowSum();
        Console.WriteLine("Enter name for product: ");
        string nameProduct = Console.ReadLine();
        Console.WriteLine("Enter integer part for product: ");
        integerPart = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coin part for product: ");
        coinPart = Convert.ToInt32(Console.ReadLine());
        var product = new Product
        {
            MoneySum = new Money
            {
                IntegerPart = integerPart,
                coinPart = coinPart
            },
            Name = nameProduct 
        };
        product.ShowProduct();
        
    }
}