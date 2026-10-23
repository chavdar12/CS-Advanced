using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class ExerciseStacksAndQueuesTests
{
    private const string Module = "002-Exercise-Stacks-And-Queues.";

    [Theory]
    [InlineData("{[()]}", "YES")]
    [InlineData("{[(])}", "NO")]
    [InlineData("((", "NO")]
    [InlineData(")(", "NO")]
    public void Ex001_BalancedParentheses(string input, string expected) =>
        AssertOutput(Module + "Ex001", input, expected);

    [Theory]
    [InlineData("5 2 32\n1 13 45 32 4", "true")]
    [InlineData("4 1 666\n666 69 13 420", "13")]
    [InlineData("3 3 1\n1 2 3", "0")]
    public void Ex002_BasicQueueOperations(string input, string expected) =>
        AssertOutput(Module + "Ex002", input, expected);

    [Theory]
    [InlineData("5 2 13\n1 13 45 32 4", "true")]
    [InlineData("4 1 666\n420 69 13 666", "13")]
    [InlineData("3 3 1\n1 2 3", "0")]
    public void Ex003_BasicStackOperations(string input, string expected) =>
        AssertOutput(Module + "Ex003", input, expected);

    [Fact]
    public void Ex004_CrossroadsSafe() => AssertOutput(Module + "Ex004", """
        10
        5
        Mercedes
        green
        Mercedes
        BMW
        Skoda
        green
        END
        """, """
        Everyone is safe.
        3 total cars passed the crossroads.
        """);

    [Fact]
    public void Ex004_CrossroadsCrash() => AssertOutput(Module + "Ex004", """
        9
        3
        Mercedes
        Hummer
        green
        Hummer
        Mercedes
        green
        END
        """, """
        A crash happened!
        Hummer was hit at e.
        """);

    [Fact]
    public void Ex005_CupsAndBottles() => AssertOutput(Module + "Ex005", """
        4 2 10 5
        3 15 15 11 6
        """, """
        Bottles: 3
        Wasted litters of water: 26
        """);

    [Fact]
    public void Ex006_FashionBoutique() => AssertOutput(Module + "Ex006", """
        5 4 8 6 3 8 7 7 9
        16
        """, "5");

    [Fact]
    public void Ex007_FastFoodComplete() => AssertOutput(Module + "Ex007", """
        348
        20 54 30 16 7 9
        """, """
        54
        Orders complete
        """);

    [Fact]
    public void Ex007_FastFoodOrdersLeft() => AssertOutput(Module + "Ex007", """
        499
        57 45 62 70 33 90 88 76
        """, """
        90
        Orders left: 76
        """);

    [Fact]
    public void Ex008_KeyRevolver() => AssertOutput(Module + "Ex008", """
        50
        2
        11 10 5 11 10 20
        15 13 16
        1500
        """, """
        Ping!
        Bang!
        Reloading!
        Bang!
        Bang!
        Reloading!
        2 bullets left. Earned $1300
        """);

    [Fact]
    public void Ex009_MaximumAndMinimumElement() => AssertOutput(Module + "Ex009", """
        9
        1 97
        2
        1 20
        2
        1 26
        1 20
        3
        1 91
        4
        """, """
        26
        20
        91, 20, 26
        """);

    [Fact]
    public void Ex010_SimpleTextEditor() => AssertOutput(Module + "Ex010", """
        8
        1 abc
        3 3
        2 3
        1 xy
        3 2
        4
        4
        3 1
        """, """
        c
        y
        a
        """);

    [Fact]
    public void Ex011_SongsQueue() => AssertOutput(Module + "Ex011", """
        All Over Again, Watch Me
        Play
        Add Watch Me
        Add Love Me Harder
        Add Promises
        Show
        Play
        Play
        Play
        Play
        """, """
        Watch Me is already contained!
        Watch Me, Love Me Harder, Promises
        No more songs!
        """);

    [Fact]
    public void Ex012_TruckTour() => AssertOutput(Module + "Ex012", """
        3
        1 5
        10 3
        3 4
        """, "1");
}
