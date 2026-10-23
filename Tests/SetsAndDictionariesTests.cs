using static CS_Advanced.Tests.ProgramRunner;

namespace CS_Advanced.Tests;

public class SetsAndDictionariesTests
{
    private const string Module = "005-Sets-And-Dictionaries-Advanced.";

    [Fact]
    public void Ex001_AverageStudentGrades() => AssertOutput(Module + "Ex001", """
        7
        John 5.20
        Maria 5.50
        John 3.20
        Maria 2.50
        Sam 2.00
        Maria 3.46
        Sam 3.00
        """, """
        John -> 5.20 3.20 (avg: 4.20)
        Maria -> 5.50 2.50 3.46 (avg: 3.82)
        Sam -> 2.00 3.00 (avg: 2.50)
        """);

    [Fact]
    public void Ex002_CitiesByContinentAndCountry() => AssertOutput(Module + "Ex002", """
        9
        Europe Bulgaria Sofia
        Asia China Beijing
        Asia Japan Tokyo
        Europe Poland Warsaw
        Europe Germany Berlin
        Europe Poland Poznan
        Europe Bulgaria Plovdiv
        Africa Nigeria Abuja
        Asia China Shanghai
        """, """
        Europe:
          Bulgaria -> Sofia, Plovdiv
          Poland -> Warsaw, Poznan
          Germany -> Berlin
        Asia:
          China -> Beijing, Shanghai
          Japan -> Tokyo
        Africa:
          Nigeria -> Abuja
        """);

    [Fact]
    public void Ex003_CountSameValues() => AssertOutput(Module + "Ex003", "-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3", """
        -2.5 - 3 times
        4 - 2 times
        3 - 4 times
        -5.5 - 1 times
        """);

    [Fact]
    public void Ex004_ParkingLotKeepsArrivalOrder() => AssertOutput(Module + "Ex004", """
        IN, CA2844AA
        IN, CA1234TA
        OUT, CA2844AA
        IN, CA9999TT
        IN, CA2866HI
        OUT, CA1234TA
        IN, CA2844AA
        OUT, CA2866HI
        IN, CA9876HH
        IN, CA2822UU
        END
        """, """
        CA9999TT
        CA2844AA
        CA9876HH
        CA2822UU
        """);

    [Fact]
    public void Ex004_ParkingLotEmpty() => AssertOutput(Module + "Ex004", """
        IN, CA2844AA
        OUT, CA2844AA
        END
        """, "Parking Lot is Empty");

    [Fact]
    public void Ex005_ProductShop() => AssertOutput(Module + "Ex005", """
        lidl, juice, 2.30
        fantastico, apple, 1.20
        kaufland, banana, 1.10
        fantastico, grape, 2.20
        Revision
        """, """
        fantastico->
        Product: apple, Price: 1.2
        Product: grape, Price: 2.2
        kaufland->
        Product: banana, Price: 1.1
        lidl->
        Product: juice, Price: 2.3
        """);

    [Fact]
    public void Ex006_RecordUniqueNames() => AssertOutput(Module + "Ex006", """
        8
        Lyle
        Bruce
        Alice
        Easton
        Shawn
        Alice
        Shawn
        Peter
        """, """
        Lyle
        Bruce
        Alice
        Easton
        Shawn
        Peter
        """);

    [Fact]
    public void Ex007_SoftUniParty() => AssertOutput(Module + "Ex007", """
        tSzE5t0p
        7IK9Yo0h
        9NoBUajQ
        Ce8vwPmE
        SVQXQCbc
        PARTY
        9NoBUajQ
        Ce8vwPmE
        SVQXQCbc
        END
        """, """
        2
        7IK9Yo0h
        tSzE5t0p
        """);
}
