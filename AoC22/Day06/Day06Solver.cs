namespace AoC22.Day06;

public class Day06Solver
{
    public string SolvePart1(string inputFileContent)
    {
        for (int i = 0; i < inputFileContent.Length - 3; i++)
        {
            if (isValidMarker(inputFileContent.Substring(i, 4), 4))
            {
                return (i + 4).ToString();
            }
        }
        return "Not found valid marker";
    }

    public bool isValidMarker(string marker, int expextedLength)
    {

        int numberOfUniqueItems = marker.ToCharArray()
            .Distinct()
            .Count();

        return numberOfUniqueItems == expextedLength;
    }

    public string SolvePart2(string inputFileContent)
    {
        for (int i = 0; i < inputFileContent.Length - 13; i++)
        {
            if (isValidMarker(inputFileContent.Substring(i, 14), 14))
            {
                return (i + 14).ToString();
            }
        }
        return "Not found valid message marker";
    }
}
