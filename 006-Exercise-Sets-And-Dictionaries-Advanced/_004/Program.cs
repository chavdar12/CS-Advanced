namespace ConsoleApp1_004;

internal static class Ranking
{
    private static void Main(string[] args)
    {
        var contestData = new Dictionary<string, string>();
        var studentData = new Dictionary<string, Dictionary<string, int>>();
        var contestPass = Console.ReadLine().Split(':');

        while (contestPass[0] != "end of contests")
        {
            var contest = contestPass[0];
            var password = contestPass[1];

            contestData.Add(contest, password);
            contestPass = Console.ReadLine().Split(':');
        }

        var sumData = Console.ReadLine().Split("=>");

        while (sumData[0] != "end of submissions")
        {
            var contest = sumData[0];
            var password = sumData[1];
            var student = sumData[2];
            var contestPoints = int.Parse(sumData[3]);

            var valid = Validation(contest, password, contestData);
            if (valid)
            {
                if (!studentData.ContainsKey(student))
                {
                    studentData.Add(student, new Dictionary<string, int>());
                    studentData[student].Add(contest, contestPoints);
                }
                else
                {
                    if (studentData[student].ContainsKey(contest))
                    {
                        if (studentData[student][contest] < contestPoints)
                            studentData[student][contest] = contestPoints;
                    }
                    else
                    {
                        studentData[student].Add(contest, contestPoints);
                    }
                }
            }

            sumData = Console.ReadLine().Split("=>");
        }

        var bestCard = string.Empty;
        var highestPoints = 0;
        foreach (var (key, value) in studentData)
        {
            var sum = value.Sum(contest => contest.Value);
            if (sum <= highestPoints) continue;
            bestCard = key;
            highestPoints = sum;
        }

        Console.WriteLine($"Best candidate is {bestCard} with total {highestPoints} points.");
        studentData = studentData.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
        Console.WriteLine("Ranking: ");
        foreach (var (key, value) in studentData)
        {
            Console.WriteLine(key);
            foreach (var (key1, i) in value.OrderByDescending(s => s.Value))
                Console.WriteLine($"#  {key1} -> {i}");
        }
    }

    private static bool Validation(string con, string pass, Dictionary<string, string> dict)
    {
        if (dict.ContainsKey(con))
            if (dict[con].Contains(pass))
                return true;

        return false;
    }
}