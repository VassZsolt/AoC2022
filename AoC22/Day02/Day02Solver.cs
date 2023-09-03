namespace AoC22.Day02;

public class Day02Solver
{
    public string SolvePart1(string inputFileContent)
    {
        return inputFileContent switch
        {
            "A X" => "4",
            "A Y" => "8",
            "A Z" => "3",
            "B X" => "1",
            "B Y" => "5",
            "B Z" => "9",
            "C X" => "7",
            "C Y" => "2",
            "C Z" => "6",
            _ => throw new NotImplementedException()
        };
    }

    public string SolvePart2(string inputFileContent)
    {
        return "";
    }

}
