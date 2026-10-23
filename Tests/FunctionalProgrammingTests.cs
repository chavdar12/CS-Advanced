using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class FunctionalProgrammingTests
{
    private const string Module = "008-Functional-Programming.";

    [Fact]
    public void Ex001_AddVat() => AssertOutput(Module + "Ex001", "1, 3, 5, 7", """
        1.20
        3.60
        6.00
        8.40
        """);

    [Fact]
    public void Ex002_UppercaseWords() => AssertOutput(Module + "Ex002",
        "The following example shows how to use Function", """
        The
        Function
        """);

    [Fact]
    public void Ex003_FilterByAgeOlder() => AssertOutput(Module + "Ex003", """
        5
        Peter, 20
        George, 18
        Reni, 17
        Simon, 22
        Lilly, 25
        older
        20
        name age
        """, """
        Peter - 20
        Simon - 22
        Lilly - 25
        """);

    [Fact]
    public void Ex003_FilterByAgeYounger() => AssertOutput(Module + "Ex003", """
        3
        Peter, 20
        George, 18
        Reni, 17
        younger
        20
        name
        """, """
        George
        Reni
        """);

    [Fact]
    public void Ex004_SortEvenNumbers() => AssertOutput(Module + "Ex004", "4, 2, 1, 3, 5, 7, 1, 4, 2, 12",
        "2, 2, 4, 4, 12");

    [Fact]
    public void Ex005_SumNumbers() => AssertOutput(Module + "Ex005", "4, 2, 1, 3, 5, 7, 1, 4, 2, 12", """
        10
        41
        """);
}
