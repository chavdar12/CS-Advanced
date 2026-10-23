using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class ExerciseFunctionalProgrammingTests
{
    private const string Module = "009-Exercise-Functional-Programming.";

    [Fact]
    public void Ex001_ActionPrint() => AssertOutput(Module + "Ex001", "Lucas Noah Tea", """
        Lucas
        Noah
        Tea
        """);

    [Theory]
    [InlineData("1 2 3 4 5\nadd\nadd\nprint\nend", "3 4 5 6 7")]
    [InlineData("5 10\nmultiply\nsubtract\nprint\nend", "9 19")]
    public void Ex002_AppliedArithmetics(string input, string expected) =>
        AssertOutput(Module + "Ex002", input, expected);

    [Theory]
    [InlineData("1 2 3 4 5 6", "2 4 6 1 3 5")]
    [InlineData("-3 2 -2 1", "-2 2 -3 1")]
    public void Ex003_CustomComparator(string input, string expected) =>
        AssertOutput(Module + "Ex003", input, expected);

    [Fact]
    public void Ex004_FindSmallest() => AssertOutput(Module + "Ex004", "1 4 3 2 1 7 13", "1");

    [Theory]
    [InlineData("1 10\nodd", "1 3 5 7 9")]
    [InlineData("20 30\neven", "20 22 24 26 28 30")]
    public void Ex005_FindEvensOrOdds(string input, string expected) =>
        AssertOutput(Module + "Ex005", input, expected);

    [Fact]
    public void Ex006_KnightsOfHonor() => AssertOutput(Module + "Ex006", "Eathan Lucas Noah", """
        Sir Eathan
        Sir Lucas
        Sir Noah
        """);

    [Theory]
    [InlineData("10\n1 1 1 2", "2 4 6 8 10")]
    [InlineData("10\n2 3", "6")]
    public void Ex007_ListOfPredicatesRequiresAllDividers(string input, string expected) =>
        AssertOutput(Module + "Ex007", input, expected);

    [Fact]
    public void Ex008_PredicateForNames() => AssertOutput(Module + "Ex008", """
        4
        Kurnelia Qnaki Geo Muk Ivan
        """, """
        Geo
        Muk
        Ivan
        """);

    [Theory]
    [InlineData("Peter Misha Stephen\nRemove StartsWith P\nDouble Length 5\nParty!",
        "Misha, Misha, Stephen are going to the party!")]
    [InlineData("Peter George Pesho\nDouble StartsWith P\nParty!",
        "Peter, Peter, George, Pesho, Pesho are going to the party!")]
    [InlineData("Peter\nRemove StartsWith P\nParty!", "Nobody is going to the party!")]
    public void Ex009_PredicateParty(string input, string expected) =>
        AssertOutput(Module + "Ex009", input, expected);

    [Fact]
    public void Ex010_ReverseAndExclude() => AssertOutput(Module + "Ex010", "1 2 3 4 5 6\n2", "5 3 1");

    [Theory]
    [InlineData("Peter Misha John\nAdd filter;Starts with;P\nAdd filter;Starts with;M\nPrint", "John")]
    [InlineData("Peter Misha Slav\nAdd filter;Starts with;P\nAdd filter;Starts with;M\nRemove filter;Starts with;M\nPrint",
        "Misha Slav")]
    [InlineData("Pa aP Bob\nAdd filter;Starts with;P\nAdd filter;Ends with;P\nPrint", "Bob")]
    public void Ex011_PartyReservationFilter(string input, string expected) =>
        AssertOutput(Module + "Ex011", input, expected);

    [Fact]
    public void Ex012_TriFunction() => AssertOutput(Module + "Ex012", "350\nRob Mary Paisley Christina", "Mary");
}
