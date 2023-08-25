using AoC22.Day01;

namespace AoC22;

internal static class Program
{
    private static void Main()
    {
        const int selectedDay = 1;
        var solver = new Day01Solver();
        
        string inputFileContent = ReadInputForDay(selectedDay);

        Console.WriteLine("Part 1:");
        string part1Result = solver.SolvePart1(inputFileContent);
        Console.WriteLine(part1Result);

        Console.WriteLine("---------------");

        Console.WriteLine("Part 2:");
        string part2Result = solver.SolvePart2(inputFileContent);
        Console.WriteLine(part2Result);

        Console.ReadLine();
    }

    private static string ReadInputForDay(int selectedDay)
    {
        return File.ReadAllText($"_inputs/day{selectedDay:D2}.txt");
    }
}