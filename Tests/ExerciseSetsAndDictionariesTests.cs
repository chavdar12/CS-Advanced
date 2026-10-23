using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class ExerciseSetsAndDictionariesTests
{
    private const string Module = "006-Exercise-Sets-And-Dictionaries-Advanced.";

    [Fact]
    public void Ex001_CountSymbols() => AssertOutput(Module + "Ex001", "SoftUni rocks", """
         : 1 time/s
        S: 1 time/s
        U: 1 time/s
        c: 1 time/s
        f: 1 time/s
        i: 1 time/s
        k: 1 time/s
        n: 1 time/s
        o: 2 time/s
        r: 1 time/s
        s: 1 time/s
        t: 1 time/s
        """);

    [Theory]
    [InlineData("3\n2\n-1\n2", "2")]
    [InlineData("5\n1\n2\n3\n1\n5", "1")]
    public void Ex002_EvenTimes(string input, string expected) =>
        AssertOutput(Module + "Ex002", input, expected);

    [Fact]
    public void Ex003_PeriodicTable() => AssertOutput(Module + "Ex003", """
        4
        Ce O
        Mo O Ce
        Ee
        Mo
        """, "Ce Ee Mo O");

    [Fact]
    public void Ex004_Ranking() => AssertOutput(Module + "Ex004", """
        Part One Interview:success
        Js Fundamentals:fundExam
        C# Fundamentals:fundPass
        Algorithms:fun
        end of contests
        C# Fundamentals=>fundPass=>Tanya=>350
        Algorithms=>fun=>Tanya=>380
        Part One Interview=>success=>Nikola=>120
        Java Basics Exam=>wrong_pass=>Teo=>400
        Part One Interview=>success=>Tanya=>220
        OOP Advanced=>password123=>Kay=>231
        C# Fundamentals=>fundPass=>Tanya=>250
        C# Fundamentals=>fundPass=>Nikola=>200
        Js Fundamentals=>fundExam=>Tanya=>400
        Algorithms=>fu=>Nikola=>999
        end of submissions
        """, """
        Best candidate is Tanya with total 1350 points.
        Ranking:
        Nikola
        #  C# Fundamentals -> 200
        #  Part One Interview -> 120
        Tanya
        #  Js Fundamentals -> 400
        #  Algorithms -> 380
        #  C# Fundamentals -> 350
        #  Part One Interview -> 220
        """);

    [Fact]
    public void Ex005_SetsOfElements() => AssertOutput(Module + "Ex005", """
        4 3
        1
        3
        5
        7
        3
        4
        5
        """, "3 5");

    [Fact]
    public void Ex006_TheVLogger() => AssertOutput(Module + "Ex006", """
        EmilConrad joined The V-Logger
        VenomTheDoctor joined The V-Logger
        Saffrona joined The V-Logger
        Saffrona followed EmilConrad
        Saffrona followed VenomTheDoctor
        EmilConrad followed VenomTheDoctor
        VenomTheDoctor followed VenomTheDoctor
        Saffrona followed EmilConrad
        Statistics
        """, """
        The V-Logger has a total of 3 vloggers in its logs.
        1. VenomTheDoctor : 2 followers, 0 following
        *  EmilConrad
        *  Saffrona
        2. EmilConrad : 1 followers, 1 following
        3. Saffrona : 0 followers, 2 following
        """);

    [Fact]
    public void Ex007_UniqueUsernames() => AssertOutput(Module + "Ex007", """
        6
        Ivan
        Ivan
        Ivan
        Pesho
        Ivan
        NiceGuy1234
        """, """
        Ivan
        Pesho
        NiceGuy1234
        """);

    [Fact]
    public void Ex008_Wardrobe() => AssertOutput(Module + "Ex008", """
        4
        Blue -> dress,jeans,hat
        Gold -> dress,t-shirt,boxers
        White -> briefs,tanktop
        Blue -> gloves
        Blue dress
        """, """
        Blue clothes:
        * dress - 1 (found!)
        * jeans - 1
        * hat - 1
        * gloves - 1
        Gold clothes:
        * dress - 1
        * t-shirt - 1
        * boxers - 1
        White clothes:
        * briefs - 1
        * tanktop - 1
        """);
}
