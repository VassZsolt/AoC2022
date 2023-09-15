using AoC22.Day04;
using FluentAssertions;

namespace AoC22.Test.Day04;

public class Day04Tests
{
    [Theory]
    [InlineData("2-4,6-8", 0)]
    [InlineData("2-3,4-5", 0)]
    [InlineData("5-7,7-9", 0)]
    [InlineData("2-8,3-7", 1)]
    [InlineData("6-6,4-6", 1)]
    [InlineData("2-6,4-8", 0)]
    [InlineData("""
        2-4,6-8
        2-3,4-5
        5-7,7-9
        2-8,3-7
        6-6,4-6
        2-6,4-8
        """, 2)]

    public void VerifyPriorityOfSharedItem(string input, int expectedResults)
    {
        Day04Solver solver = new Day04Solver();
        int result = int.Parse(solver.SolvePart1(input));
        result.Should().Be(expectedResults);
    }
}
