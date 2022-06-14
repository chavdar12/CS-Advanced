namespace _001;

internal static class JaggedArrayModification
{
    private static void Main(string[] args)
    {
        var rows = int.Parse(Console.ReadLine());
        var jaggedArray = new int[rows][];
        for (var i = 0; i < rows; i++) jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var command = Console.ReadLine().Split();
        while (command[0] != "END")
        {
            switch (command[0])
            {
                case "Add":
                    var row = int.Parse(command[1]);
                    var col = int.Parse(command[2]);
                    var add = int.Parse(command[3]);
                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                        jaggedArray[row][col] += add;
                    else
                        Console.WriteLine("Invalid coordinates");

                    break;
                case "Subtract":
                    row = int.Parse(command[1]);
                    col = int.Parse(command[2]);
                    var sub = int.Parse(command[3]);
                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                        jaggedArray[row][col] -= sub;
                    else
                        Console.WriteLine("Invalid coordinates");

                    break;
            }

            command = Console.ReadLine().Split();
        }

        for (var i = 0; i < rows; i++) Console.WriteLine(string.Join(" ", jaggedArray[i]));
    }
}