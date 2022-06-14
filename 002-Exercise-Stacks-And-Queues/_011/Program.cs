namespace _011;

internal static class SongsQueue
{
    private static void Main(string[] args)
    {
        var songs = new Queue<string>(Console.ReadLine().Split(", "));
        var command = Console.ReadLine();

        while (songs.Count > 0)
        {
            var indexSeparator = command.IndexOf(' ');
            switch (indexSeparator == -1 ? command : command.Substring(0, indexSeparator))
            {
                case "Play":
                    songs.Dequeue();
                    break;
                case "Add":
                    var songToAdd = command.Substring(indexSeparator + 1);
                    if (!songs.Contains(songToAdd))
                        songs.Enqueue(songToAdd);
                    else
                        Console.WriteLine($"{songToAdd} is already contained!");
                    break;
                case "Show":
                    Console.WriteLine(string.Join(", ", songs));
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine("No more songs!");
    }
}