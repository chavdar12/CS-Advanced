namespace _002;

internal static class CitiesByContinentAndCountry
{
    private static void Main(string[] args)
    {
        var continents = new Dictionary<string, List<Country>>();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var cont = info[0];
            var country = info[1];
            var city = info[2];
            var currentCountry = new Country(country);
            currentCountry.Cities = new List<string>();
            if (!continents.ContainsKey(cont)) continents.Add(cont, new List<Country>());

            var idx = continents[cont].FindIndex(c => c.Name == country);
            if (idx == -1)
            {
                currentCountry.Cities.Add(city);
                continents[cont].Add(currentCountry);
            }
            else
            {
                continents[cont][idx].Cities.Add(city);
            }
        }

        foreach (var (key, value) in continents)
        {
            Console.WriteLine($"{key}:");
            Console.WriteLine(string.Join(Environment.NewLine, value));
        }
    }
}

internal class Country
{
    public Country(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public List<string> Cities { get; set; }

    public override string ToString()
    {
        return $"  {Name} -> {string.Join(", ", Cities)}";
    }
}