using System.Globalization;
using System.Reflection;

// Console is process-wide state, so tests that redirect it must not run in parallel.
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace CS_Advanced.Tests;

public static class ProgramRunner
{
    /// <summary>
    /// Runs an exercise's Main with <paramref name="input"/> as stdin and returns stdout,
    /// with line endings normalized and trailing whitespace trimmed from every line.
    /// </summary>
    public static string Run(string assemblyName, string input = "")
    {
        var entryPoint = Assembly.Load(assemblyName).EntryPoint
                         ?? throw new InvalidOperationException($"{assemblyName} has no entry point");
        var output = new StringWriter();
        var (originalIn, originalOut, originalCulture) = (Console.In, Console.Out, CultureInfo.CurrentCulture);
        Console.SetIn(new StringReader(input));
        Console.SetOut(output);
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        try
        {
            object?[]? args = entryPoint.GetParameters().Length == 0 ? null : [Array.Empty<string>()];
            entryPoint.Invoke(null, BindingFlags.DoNotWrapExceptions, null, args, null);
        }
        finally
        {
            Console.SetIn(originalIn);
            Console.SetOut(originalOut);
            CultureInfo.CurrentCulture = originalCulture;
        }

        var lines = output.ToString().ReplaceLineEndings("\n").Split('\n').Select(l => l.TrimEnd());
        return string.Join("\n", lines).TrimEnd();
    }

    public static void AssertOutput(string assemblyName, string input, string expected)
    {
        Assert.Equal(expected.ReplaceLineEndings("\n"), Run(assemblyName, input));
    }
}
