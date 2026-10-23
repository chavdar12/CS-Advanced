namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        string reg;
        var licensePlates = new List<string>();
        while ((reg = Console.ReadLine()) != "END")
        {
            var split = reg.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            switch (split[0])
            {
                case "IN":
                    if (!licensePlates.Contains(split[1])) licensePlates.Add(split[1]);
                    break;
                case "OUT":
                    licensePlates.Remove(split[1]);
                    break;
            }
        }

        Console.WriteLine(
            licensePlates.Any() ? string.Join(Environment.NewLine, licensePlates) : "Parking Lot is Empty");
    }
}