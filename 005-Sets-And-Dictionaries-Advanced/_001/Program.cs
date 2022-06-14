namespace _001;

internal static class AverageStudentGrades
{
    private static void Main(string[] args)
    {
        var studentGrades = new Dictionary<string, List<decimal>>();
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var studentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var studentName = studentInfo[0];
            var grade = decimal.Parse(studentInfo[1]);
            if (!studentGrades.ContainsKey(studentName)) studentGrades.Add(studentName, new List<decimal>());
            studentGrades[studentName].Add(grade);
        }

        foreach (var student in studentGrades)
            Console.WriteLine(
                $"{student.Key} -> {string.Join(" ", student.Value.Select(v => $"{v:f2}"))} (avg: {student.Value.Average():f2})");
    }
}