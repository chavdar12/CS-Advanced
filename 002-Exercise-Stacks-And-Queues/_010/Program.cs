using System.Text;

namespace _010;

internal class SimpleTextEditor
{
    private static void Main(string[] args)
    {
        var numberRotations = int.Parse(Console.ReadLine());
        var sb = new StringBuilder();
        var pushedPhrases = new Stack<string>();
        for (var i = 0; i < numberRotations; i++)
        {
            var command = Console.ReadLine().Split();
            switch (command[0])
            {
                case "1":
                    pushedPhrases.Push(sb.ToString());
                    var strToAppend = command[1];
                    sb.Append(strToAppend);
                    break;
                case "2":
                    pushedPhrases.Push(sb.ToString());
                    var countChars = int.Parse(command[1]);
                    sb.Remove(sb.Length - countChars, countChars);
                    break;
                case "3":
                    var index = int.Parse(command[1]);
                    Console.WriteLine(sb[index - 1]);
                    break;
                case "4":
                    if (sb.Length == 0)
                        sb.Append(pushedPhrases.Pop());
                    else
                        sb.Replace(sb.ToString(), pushedPhrases.Pop());
                    break;
            }
        }
    }
}