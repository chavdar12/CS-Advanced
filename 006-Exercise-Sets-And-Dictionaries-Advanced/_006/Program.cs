namespace _006;

internal static class TheVLogger
{
    private static void Main(string[] args)
    {
        var theVLogger = new Dictionary<string, Vlogger>();
        string command;
        while ((command = Console.ReadLine()) != "Statistics")
        {
            var split = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var username = split[0];
            var username2 = split[2];
            switch (split[1])
            {
                case "joined":
                    if (!theVLogger.ContainsKey(username)) theVLogger.Add(username, new Vlogger());
                    break;
                case "followed":
                    if (theVLogger.ContainsKey(username) && theVLogger.ContainsKey(username2) && username2 != username)
                    {
                        theVLogger[username].Following.Add(username2);
                        theVLogger[username2].Followers.Add(username);
                    }

                    break;
            }
        }

        theVLogger = theVLogger.OrderByDescending(v => v.Value.Followers.Count).ThenBy(v => v.Value.Following.Count)
            .ToDictionary(k => k.Key, v => v.Value);
        Console.WriteLine($"The V-Logger has a total of {theVLogger.Count} vloggers in its logs.");
        Console.WriteLine(
            $"1. {theVLogger.First().Key} : {theVLogger.First().Value.Followers.Count} followers, {theVLogger.First().Value.Following.Count} following");
        foreach (var follower in theVLogger.First().Value.Followers.OrderBy(f => f))
            Console.WriteLine($"*  {follower}");

        theVLogger.Remove(theVLogger.First().Key);
        var counter = 2;
        foreach (var vlogger in theVLogger.OrderByDescending(f => f.Value.Followers.Count)
                     .ThenBy(f => f.Value.Following.Count))
        {
            Console.WriteLine(
                $"{counter}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");
            counter++;
        }
    }
}

internal class Vlogger
{
    public Vlogger()
    {
        Followers = new HashSet<string>();
        Following = new HashSet<string>();
    }

    public HashSet<string> Followers { get; set; }
    public HashSet<string> Following { get; set; }
}