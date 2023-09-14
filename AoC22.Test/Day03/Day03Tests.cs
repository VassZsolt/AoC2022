using AoC22.Day03;
using FluentAssertions;

namespace AoC22.Test.Day03;

public class Day03Tests
{
    [Theory]
    [InlineData("vJrwpWtwJgWrhcsFMMfFFhFp", 16)]
    [InlineData("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 38)]
    [InlineData("PmmdzqPrVvPwwTWBwg", 42)]
    [InlineData("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", 22)]
    [InlineData("ttgJtRGJQctTZtZT", 20)]
    [InlineData("CrZsJsPPZsGzwwsLwLmpwMDw", 19)]
    public void VerifyPriorityOfSharedItem(string input, int expectedResults)
    {
        Day03Solver solver = new Day03Solver();
        int result = int.Parse(solver.SolvePart1(input));
        result.Should().Be(expectedResults);
    }
}
