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

    [Theory]
    [InlineData("""
        A Y
        B X
        C Z
        """, 15)]
    public void ScoresMultipleRoundsCorrectly(string input, int expectedResult)
    {
        Day02Solver solver = new Day02Solver();
        int result = int.Parse(solver.SolvePart1(input));
        result.Should().Be(expectedResult);
    }
}
public class Day02Part2Tests
{
    [Theory]
    [InlineData("A X", 3)] // Need lose against Rock => Scissors => 0+3 = 3
    [InlineData("A Y", 4)] // Need draw against Rock => Rock => 3+1 = 4
    [InlineData("A Z", 8)] // Need win against Rock => Paper => 6+2 = 8
    [InlineData("B X", 1)] // Need lose against Paper => Rock => 0+1 = 1
    [InlineData("B Y", 5)] // Need draw against Paper => Paper => 3+2 = 5
    [InlineData("B Z", 9)] // Need win against Paper => Scissors => 6+3 = 9
    [InlineData("C X", 2)] // Need lose against Scissors => Paper => 0+2 = 2
    [InlineData("C Y", 6)] // Need draw against Scissors => Scissors => 3+3 = 6
    [InlineData("C Z", 7)] // Need win against Scissors => Rock => 6+1 = 7
    public void ScoresOneRoundCorrectly(string input, int expectedResult)
    {
        Day02Solver solver = new Day02Solver();
        int result = int.Parse(solver.SolvePart2(input));
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("""
        A Y
        B X
        C Z
        """, 12)]
    public void ScoresMultipleRoundsCorrectly(string input, int expectedResult)
    {
        Day02Solver solver = new Day02Solver();
        int result = int.Parse(solver.SolvePart2(input));
        result.Should().Be(expectedResult);
    }
}
