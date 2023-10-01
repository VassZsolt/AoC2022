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

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", "7")]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", "5")]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", "6")]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", "10")]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", "11")]

    public void TestPart1(string input, string expectedResult)
    {
        Day06Solver solver = new Day06Solver();
        string result = solver.SolvePart1(input);

        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("abc")] // Túl rövid
    [InlineData("abcdefgijklmno")] // Túl hosszú
    [InlineData("abcdefghijklma")] // Tartalmaz ismétlődést

    public void ShouldBeInvalidMessageMarker(string messageMarker)
    {
        Day06Solver solver = new Day06Solver();
        bool result = solver.isValidIdentifier(messageMarker);

        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("abcdefghijklmn")] // Megfelelő

    public void ShouldBeValidMessageMarker(string messageMarker)
    {
        Day06Solver solver = new Day06Solver();
        bool result = solver.isValidIdentifier(messageMarker);

        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", "19")]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", "23")]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", "23")]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", "29")]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", "26")]

    public void TestPart2(string input, string expectedResult)
    {
        Day06Solver solver = new Day06Solver();
        string result = solver.SolvePart2(input);

        result.Should().Be(expectedResult);
    }


}
