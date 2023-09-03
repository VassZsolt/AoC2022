using AoC22.Day02;
using FluentAssertions;

namespace AoC22.Test.Day02;

public class Day02Part1Tests
{
    [Theory]
    [InlineData("A X", 4)] // Rock vs Rock => 3+1 = 4
    [InlineData("A Y", 8)] // Rock vs Paper => 6+2 = 8
    [InlineData("A Z", 3)] // Rock vs Scissors => 0+3 = 3
    public void ScoresOneRoundCorrectly(string input, int expectedResult)
    {
        Day02Solver solver = new Day02Solver();
        int result = int.Parse(solver.SolvePart1(input));
        result.Should().Be(expectedResult);
    }
}
