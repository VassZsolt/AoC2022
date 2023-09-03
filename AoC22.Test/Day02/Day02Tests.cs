using AoC22.Day02;
using FluentAssertions;

namespace AoC22.Test.Day02;

public class Day02Part1Tests
{
    [Theory]
    [InlineData("A X", 4)] // Rock vs Rock => 3+1 = 4
    public void ScoresOneRoundCorrectly(string input, int expectedResult)
    {
        Day02Solver solver = new Day02Solver();
        int result = int.Parse(solver.SolvePart1(input));
        result.Should().Be(expectedResult);
    }
}
