namespace _008;

internal static class Wardrobe
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var clothes = new List<Clothes>();
        for (var i = 0; i < n; i++)
        {
            var firstSplit = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            var color = firstSplit[0];
            var secondSplit = firstSplit[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
            var currentClothing = new Clothes(color, new List<Type>());
            foreach (var s in secondSplit)
            {
                var typeOfClothing = new Type(s);
                if (clothes.All(c => c.Color != currentClothing.Color)) clothes.Add(currentClothing);

                var idx = clothes.FindIndex(c => c.Color == color);
                if (clothes[idx].Type.All(t => t.ClothesType != s)) clothes[idx].Type.Add(typeOfClothing);
                var countIdx = clothes[idx].Type.FindIndex(t => t.ClothesType == s);
                clothes[idx].Type[countIdx].Count++;
            }
        }

        var lookingFor = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var colour = lookingFor[0];
        var clothing = lookingFor[1];
        foreach (var cloth in clothes)
        {
            Console.WriteLine($"{cloth.Color} clothes:");
            foreach (var type in cloth.Type) Console.WriteLine(type.ToStrings(clothing, colour, cloth.Color));
        }
    }
}

internal class Clothes
{
    public Clothes(string color, List<Type> type)
    {
        Color = color;
        Type = type;
    }

    public string Color { get; set; }
    public List<Type> Type { get; set; }
}

internal class Type
{
    public Type(string type)
    {
        ClothesType = type;
    }

    public string ClothesType { get; set; }
    public int Count { get; set; }

    public string ToStrings(string type, string color, string color2)
    {
        return type == ClothesType && color == color2
            ? $"* {ClothesType} - {Count} (found!)"
            : $"* {ClothesType} - {Count}";
    }
}