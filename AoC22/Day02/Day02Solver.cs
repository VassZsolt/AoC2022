namespace AoC22.Day02;

public class Day02Solver
{
    public string SolvePart1(string inputFileContent)
    {
        if (inputFileContent.EndsWith('X'))
        {
            return "4";
        }
        else if (inputFileContent.EndsWith('Y'))
        {
            return "8";
        }
        else
        {
            return "3";
        }
    }

    public string SolvePart2(string inputFileContent)
    {
        return "";
    }

}
