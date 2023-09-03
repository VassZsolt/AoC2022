using AoC22.Day02;
using FluentAssertions;

namespace AoC22.Test.Day02;

public class Day02Part1Tests
{
    [Theory]
    [InlineData("A X", 4)] // Rock vs Rock => 3+1 = 4
    [InlineData("A Y", 8)] // Rock vs Paper => 6+2 = 8
    [InlineData("A Z", 3)] // Rock vs Scissors => 0+3 = 3
    [InlineData("B X", 1)] // Paper vs Rock => 0+1 = 1
    [InlineData("B Y", 5)] // Paper vs Paper => 3+2 = 5
    [InlineData("B Z", 9)] // Paper vs Scissors => 6+3 = 9
    [InlineData("C X", 7)] // Scissors vs Rock => 6+1 = 7
    [InlineData("C Y", 2)] // Scissors vs Paper => 0+2 = 2
    [InlineData("C Z", 6)] // Scissors vs Scissors => 3+3 = 6
    public void ScoresOneRoundCorrectly(string input, int expectedResult)
    {
        Day02Solver solver = new Day02Solver();
        int result = int.Parse(solver.SolvePart1(input));
        result.Should().Be(expectedResult);
    }
}
