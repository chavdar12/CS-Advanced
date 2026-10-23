using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class ExerciseMultidimensionalArraysTests
{
    private const string Module = "004-Exercise-Multidimensional-Arrays.";

    [Fact]
    public void Ex001_Bombs() => AssertOutput(Module + "Ex001", """
        4
        8 3 2 5
        6 4 7 9
        9 9 3 6
        6 8 1 2
        1,2 2,1 2,0
        """, """
        Alive cells: 3
        Sum: 12
        8 -4 -5 -2
        -3 -3 0 2
        0 0 -4 -1
        -3 -1 -1 2
        """);

    [Fact]
    public void Ex002_DiagonalDifference() => AssertOutput(Module + "Ex002", """
        3
        11 2 4
        4 5 6
        10 8 -12
        """, "15");

    [Fact]
    public void Ex003_JaggedArrayManipulator() => AssertOutput(Module + "Ex003", """
        5
        10 20 30
        1 2 3
        2
        2
        10 10
        Add 4 1 3
        Subtract 0 0 5
        Add 9 9 9
        End
        """, """
        15 40 60
        1 2 3
        2
        2
        5 8
        """);

    [Theory]
    [InlineData("5\n0K0K0\nK000K\n00K00\nK000K\n0K0K0", "1")]
    [InlineData("2\nKK\nKK", "0")]
    [InlineData("8\n0K0KKK00\n0K00KKKK\n00K0000K\nKKKKKK0K\nK0K0000K\nKK00000K\n00K0K000\n000K00KK", "12")]
    public void Ex004_KnightGame(string input, string expected) =>
        AssertOutput(Module + "Ex004", input, expected);

    [Fact]
    public void Ex005_MatrixShuffling() => AssertOutput(Module + "Ex005", """
        2 3
        1 2 3
        4 5 6
        swap 0 0 1 1
        swap 10 9 8 7
        swap 0 1 1 0
        END
        """, """
        5 2 3
        4 1 6
        Invalid input!
        5 4 3
        2 1 6
        """);

    [Fact]
    public void Ex006_MaximalSum() => AssertOutput(Module + "Ex006", """
        4 5
        1 5 5 2 4
        2 1 4 14 3
        3 7 11 2 8
        4 8 12 16 4
        """, """
        Sum = 75
        1 4 14
        7 11 2
        8 12 16
        """);

    [Fact]
    public void Ex007_MinerGameOver() => AssertOutput(Module + "Ex007", """
        5
        up right right up right
        * * * c *
        * * * e *
        * * c * *
        s * * c *
        * * c * *
        """, "Game over! (1, 3)");

    [Fact]
    public void Ex007_MinerCollectsAll() => AssertOutput(Module + "Ex007", """
        4
        up right right right down
        * * * e
        * * c *
        * s * c
        * * * *
        """, "You collected all coals! (2, 3)");

    [Fact]
    public void Ex007_MinerCoalsLeft() => AssertOutput(Module + "Ex007", """
        3
        right
        s * c
        * * *
        c * *
        """, "2 coals left. (0, 1)");

    [Fact]
    public void Ex008_BunniesWon() => AssertOutput(Module + "Ex008", """
        5 8
        .......B
        ...B....
        ....B..B
        ........
        ..P.....
        ULLL
        """, """
        BBBBBBBB
        BBBBBBBB
        BBBBBBBB
        .BBBBBBB
        ..BBBBBB
        won: 3 0
        """);

    [Fact]
    public void Ex008_BunniesDead() => AssertOutput(Module + "Ex008", """
        4 5
        .....
        .....
        .B...
        ...P.
        LLLLLLLL
        """, """
        .B...
        BBB..
        BBBB.
        BBB..
        dead: 3 1
        """);

    [Fact]
    public void Ex009_SnakeMoves() => AssertOutput(Module + "Ex009", """
        5 6
        SoftUni
        """, """
        SoftUn
        UtfoSi
        niSoft
        foSinU
        tUniSo
        """);
}
