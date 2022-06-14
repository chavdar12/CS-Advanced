namespace _005;

internal static class ProductShop
{
    private static void Main(string[] args)
    {
        var stores = new List<Store>();
        string storeInfo;
        while ((storeInfo = Console.ReadLine()) != "Revision")
        {
            var info = storeInfo.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var store = info[0];
            var product = info[1];
            var price = double.Parse(info[2]);
            var currentStore = new Store(store, new List<Product>());
            var currentProduct = new Product(product, price);

            if (stores.All(s => s.Name != store)) stores.Add(currentStore);
            var idx = stores.FindIndex(s => s.Name == store);
            stores[idx].Product.Add(currentProduct);
        }

        Console.WriteLine(string.Join(Environment.NewLine, stores.OrderBy(s => s.Name)));
    }
}

internal class Store
{
    public Store(string name, List<Product> product)
    {
        Name = name;
        Product = product;
    }

    public string Name { get; set; }
    public List<Product> Product { get; set; }

    public override string ToString()
    {
        return $"{Name}->{Environment.NewLine}{string.Join(Environment.NewLine, Product)}";
    }
}

internal class Product
{
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    private string Name { get; set; }
    private double Price { get; set; }

    public override string ToString()
    {
        return $"Product: {Name}, Price: {Price}";
    }
}