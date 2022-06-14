namespace _007;

internal static class SoftUniParty
{
    private static void Main(string[] args)
    {
        var vip = new HashSet<string>();
        var regular = new HashSet<string>();
        var partyStart = false;
        string guest;
        while ((guest = Console.ReadLine()) != "END")
        {
            if (guest == "PARTY")
            {
                partyStart = true;
                continue;
            }

            if (partyStart)
            {
                vip.Remove(guest);
                regular.Remove(guest);
            }
            else
            {
                if (char.IsDigit(guest[0]))
                    vip.Add(guest);
                else
                    regular.Add(guest);
            }
        }

        Console.WriteLine(vip.Count + regular.Count);
        foreach (var g in vip) Console.WriteLine(g);
        foreach (var g in regular) Console.WriteLine(g);
    }
}