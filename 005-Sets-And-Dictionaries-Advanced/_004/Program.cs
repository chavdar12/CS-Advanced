namespace _004;

internal static class ParkingLot
{
    private static void Main(string[] args)
    {
        string reg;
        var licensePlates = new HashSet<string>();
        while ((reg = Console.ReadLine()) != "END")
        {
            var split = reg.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            switch (split[0])
            {
                case "IN":
                    licensePlates.Add(split[1]);
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