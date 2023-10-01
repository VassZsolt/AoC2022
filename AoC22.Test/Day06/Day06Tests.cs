using AoC22.Day05;
using AoC22.Day06;
using FluentAssertions;

namespace AoC22.Test.Day06;
public class Day06Tests
{
    [Theory]
    [InlineData("abc")] // Túl rövid
    [InlineData("abcde")] // Túl hosszú
    [InlineData("abca")] // Tartalmaz ismétlődést

    public void ShouldBeInvalidIdentitfier(string identifier)
    {
        Day06Solver solver = new Day06Solver();
        bool result = solver.isValidIdentifier(identifier);

        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("abcd")] // Megfelő

    public void ShouldBeValidIdentitfier(string identifier)
    {
        Day06Solver solver = new Day06Solver();
        bool result = solver.isValidIdentifier(identifier);

        result.Should().BeTrue();
    }


}
