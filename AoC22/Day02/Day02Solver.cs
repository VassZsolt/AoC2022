namespace AoC22.Day02;

public class Day02Solver
{
    private const int DrawScore = 3;
    private const int WinScore = 6;

    public string SolvePart1(string inputFileContent)
    {
        List<string> roundInputs = inputFileContent
            .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string result = roundInputs
            .Select(r => Part1_ScoreOneRound(r))
            .Sum()
            .ToString();

        return result;
    }

    private static int Part1_ScoreOneRound(string roundInput)
    {
        return roundInput switch
        {
            "A X" => 4,
            "A Y" => 8,
            "A Z" => 3,
            "B X" => 1,
            "B Y" => 5,
            "B Z" => 9,
            "C X" => 7,
            "C Y" => 2,
            "C Z" => 6,
            _ => throw new NotImplementedException()
        };
    }

    public string SolvePart2(string inputFileContent)
    {
        List<string> roundInputs = inputFileContent
            .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string result = roundInputs
            .Select(r => Part2_ScoreOneRound(r))
            .Sum()
            .ToString();

        return result;
    }

    private static int Part2_ScoreOneRound(string roundInput)
    {
        return roundInput switch
        {
            "A X" => 3,
            "A Y" => 4,
            "A Z" => 8,
            "B X" => 1,
            "B Y" => 5,
            "B Z" => 9,
            "C X" => 2,
            "C Y" => 6,
            "C Z" => 7,
            _ => throw new NotImplementedException()
        };
    }
}
