using AoC22.Day01;
using FluentAssertions;

namespace AoC22.Test.Day01;

public sealed class Day01Tests
{
    [Fact]
    public void Part1_Example_from_website()
    {
        // Arrange 
        string input = """
            1000
            2000
            3000

            4000

            5000
            6000

            7000
            8000
            9000

            10000
            """;
        Day01Solver solver = new Day01Solver();

        // Act
        string result = solver.SolvePart1(input);

        // Assert
        result.Should().Be("24000");
    }
}
