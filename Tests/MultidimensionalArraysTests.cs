using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class MultidimensionalArraysTests
{
    private const string Module = "003-Multidimensional-Arrays.";

    [Fact]
    public void Ex001_JaggedArrayModification() => AssertOutput(Module + "Ex001", """
        3
        1 2 3
        4 5 6
        7 8 9
        Add 0 0 5
        Subtract 1 1 2
        Add 3 3 1
        END
        """, """
        Invalid coordinates
        6 2 3
        4 3 6
        7 8 9
        """);

    [Fact]
    public void Ex002_PascalTriangle() => AssertOutput(Module + "Ex002", "4", """
        1
        1 1
        1 2 1
        1 3 3 1
        """);

    [Fact]
    public void Ex003_PrimaryDiagonal() => AssertOutput(Module + "Ex003", """
        3
        11 2 4
        4 5 6
        10 8 -12
        """, "4");

    [Fact]
    public void Ex004_SquareWithMaximumSum() => AssertOutput(Module + "Ex004", """
        3, 6
        7, 1, 3, 3, 2, 1
        1, 3, 9, 8, 5, 6
        4, 6, 7, 9, 1, 0
        """, """
        9 8
        7 9
        33
        """);

    [Fact]
    public void Ex004_SquareWithMaximumSumAllNegative() => AssertOutput(Module + "Ex004", """
        2, 3
        -1, -2, -3
        -4, -5, -6
        """, """
        -1 -2
        -4 -5
        -12
        """);

    [Fact]
    public void Ex005_SumMatrixColumns() => AssertOutput(Module + "Ex005", """
        2, 3
        1 2 3
        4 5 6
        """, """
        5
        7
        9
        """);

    [Fact]
    public void Ex006_SumMatrixElements() => AssertOutput(Module + "Ex006", """
        3, 6
        7, 1, 3, 3, 2, 1
        1, 3, 9, 8, 5, 6
        4, 6, 7, 9, 1, 0
        """, """
        3
        6
        76
        """);

    [Theory]
    [InlineData("3\nABC\nDEF\nX!@\n!", "(2, 1)")]
    [InlineData("2\nAB\nCD\nZ", "Z does not occur in the matrix")]
    public void Ex007_SymbolInMatrix(string input, string expected) =>
        AssertOutput(Module + "Ex007", input, expected);
}
