using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class StacksAndQueuesTests
{
    private const string Module = "001-Stacks-And-Queues.";

    [Fact]
    public void Ex001_HotPotato() => AssertOutput(Module + "Ex001", """
        Alva James William
        2
        """, """
        Removed James
        Removed Alva
        Last is William
        """);

    [Fact]
    public void Ex002_MatchingBrackets() => AssertOutput(Module + "Ex002",
        "1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5", """
        (2 + 3)
        (3 + 1)
        (2 - (2 + 3) * 4 / (3 + 1))
        """);

    [Theory]
    [InlineData("1 2 3 4 5 6", "2, 4, 6")]
    [InlineData("2 1 4", "2, 4")]
    public void Ex003_PrintEvenNumbersKeepsOrder(string input, string expected) =>
        AssertOutput(Module + "Ex003", input, expected);

    [Fact]
    public void Ex004_ReverseString() => AssertOutput(Module + "Ex004", "I Love C#", "#C evoL I");

    [Fact]
    public void Ex005_SimpleCalculator() => AssertOutput(Module + "Ex005", "2 + 5 + 10 - 2 - 1", "14");

    [Fact]
    public void Ex006_StackSum() => AssertOutput(Module + "Ex006", """
        1 2 3 4
        adD 5 6
        REmove 3
        eNd
        """, "Sum: 6");

    [Fact]
    public void Ex007_Supermarket() => AssertOutput(Module + "Ex007", """
        Liam
        Noah
        James
        Paid
        Oliver
        Lucas
        Logan
        Tiana
        End
        """, """
        Liam
        Noah
        James
        4 people remaining.
        """);

    [Fact]
    public void Ex008_TrafficJam() => AssertOutput(Module + "Ex008", """
        3
        Enzo's car
        Jade's car
        Mercedes CLS
        Audi
        green
        BMW X5
        green
        end
        """, """
        Enzo's car passed!
        Jade's car passed!
        Mercedes CLS passed!
        Audi passed!
        BMW X5 passed!
        5 cars passed the crossroads.
        """);
}
