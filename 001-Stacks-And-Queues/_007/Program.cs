namespace _007;

internal static class Supermarket
{
    private static void Main(string[] args)
    {
        var customers = new Queue<string>();
        var customer = Console.ReadLine();
        while (customer != "End")
        {
            if (customer == "Paid")
            {
                foreach (var customer1 in customers) Console.WriteLine(customer1);
                customers.Clear();
                customer = Console.ReadLine();
                continue;
            }

            customers.Enqueue(customer);
            customer = Console.ReadLine();
        }

        Console.WriteLine($"{customers.Count} people remaining.");
    }
}