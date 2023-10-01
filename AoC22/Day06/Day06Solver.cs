namespace AoC22.Day06;

public class Day06Solver
{
    public string SolvePart1(string inputFileContent)
    {
        return "";
    }

    public bool isValidIdentifier(string identifier)
    {
        if (identifier.Length != 4)
        {
            return false;
        }
        else
        {
            int numberOfUniqueItems =identifier.ToCharArray()
                .Distinct()
                .Count();

            return numberOfUniqueItems switch
            {
                4 => true,
                _ => false
            };
        }
    }

    public string SolvePart2(string inputFileContent)
    {
        return "";
    }
}
