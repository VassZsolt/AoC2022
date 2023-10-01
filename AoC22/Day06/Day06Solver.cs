namespace AoC22.Day06;

public class Day06Solver
{
    public string SolvePart1(string inputFileContent)
    {
        for (int i = 0; i < inputFileContent.Length - 3; i++)
        {
            if (isValidIdentifier(inputFileContent.Substring(i, 4)))
            {
                return (i + 4).ToString();
            }
        }
        return "Not found valid identifier";
    }

    public bool isValidIdentifier(string identifier)
    {
        if (identifier.Length != 4)
        {
            return false;
        }
        else
        {
            int numberOfUniqueItems = identifier.ToCharArray()
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
