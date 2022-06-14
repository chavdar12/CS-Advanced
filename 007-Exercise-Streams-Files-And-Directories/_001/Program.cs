using System.Text;

namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        // EvenLines();
        // LineNumbers();
        // WordCount();
        // CopyBinaryFile();
        // DirectoryTraversal();
        // ZipFile();
    }

    private static void ZipFile()
    {
        System.IO.Compression.ZipFile.CreateFromDirectory("../../../Resources", "../../../archived.zip");
        System.IO.Compression.ZipFile.ExtractToDirectory("../../../archived.zip",
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
    }

    private static void DirectoryTraversal()
    {
        var files = Directory.GetFiles("../../../");
        var
            fileExtensions = new Dictionary<string, Dictionary<string, double>>();
        var sb = new StringBuilder();
        foreach (var f in files)
        {
            var file = new FileInfo(f);
            var extension = Path.GetExtension(f);
            var fileName = Path.GetFileName(f);
            var sizeKb = file.Length / 1024.0;
            if (!fileExtensions.ContainsKey(extension)) fileExtensions.Add(extension, new Dictionary<string, double>());

            fileExtensions[extension].Add(fileName, sizeKb);
        }

        foreach (var (key, value) in fileExtensions.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
        {
            sb.AppendLine(key);
            foreach (var (s, d) in value.OrderBy(f => f.Value))
                sb.AppendLine($"--{s} - {d:f3}kb");
        }

        var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        var dest = Path.Combine(desktopPath, "report.txt");
        File.WriteAllText(dest, sb.ToString());
    }


    private static void CopyBinaryFile()
    {
        var fs = new FileStream("../../../copyMe.png", FileMode.Open);
        var fsCopyTo = new FileStream("../../../copied.png", FileMode.Create);
        fs.CopyTo(fsCopyTo);
    }


    private static void WordCount()
    {
        var words = File.ReadAllLines("../../../words.txt");
        var wordsCount = new Dictionary<string, int>();
        var lines = File.ReadAllLines("../../../text.txt");
        for (var i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Replace("-", "");
            lines[i] = lines[i].Replace(",", "");
            lines[i] = lines[i].Replace(".", "");
            lines[i] = lines[i].Replace("!", "");
            lines[i] = lines[i].Replace("?", "");
        }

        foreach (var word in words)
        foreach (var l in lines)
        {
            var lineArr = l.Split();
            foreach (var arr in lineArr)
                if (string.Compare(word, arr, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    if (!wordsCount.ContainsKey(word)) wordsCount.Add(word, 0);

                    wordsCount[word]++;
                }
        }

        var toPrint = wordsCount.Select(i => $"{i.Key} - {i.Value}").ToList();

        File.AppendAllLines("../../../actualResult.txt", toPrint);
        wordsCount = wordsCount.OrderByDescending(v => v.Value).ToDictionary(k => k.Key, v => v.Value);
        toPrint.Clear();
        foreach (var i in wordsCount) toPrint.Add($"{i.Key} - {i.Value}");

        File.AppendAllLines("../../../expectedResult.txt", toPrint);
    }


    private static void LineNumbers()
    {
        var lines = File.ReadAllLines("../../../text.txt");
        for (var i = 0; i < lines.Length; i++)
        {
            var letterCount = lines[i].Count(c => char.IsLetter(c));
            var punchCount = lines[i].Count(c => char.IsPunctuation(c));
            lines[i] = lines[i].Insert(0, $"Line {i + 1} ");
            lines[i] = lines[i].Insert(lines[i].Length, $" ({letterCount})({punchCount})");
        }

        File.WriteAllLines("../../../output.txt", lines);
    }


    private static void EvenLines()
    {
        string[] specialSymbols = {"-", ",", ".", "!", "?"};
        var readText = new StreamReader("../../../text.txt");
        var counter = 0;
        while (!readText.EndOfStream)
        {
            var line = readText.ReadLine();
            if (counter++ % 2 != 0) continue;
            line = specialSymbols.Aggregate(line, (current, specialSymbol) => current.Replace(specialSymbol, "@"));

            Console.WriteLine(string.Join(" ", line.Split().Reverse()));
        }
    }
}