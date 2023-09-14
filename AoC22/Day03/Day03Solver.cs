namespace AoC22.Day03;

public class Day03Solver
{
    public string SolvePart1(string inputFileContent) // A prioritások össszege
    {
        string result = "";

        List<string> rucksacks = inputFileContent
            .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        foreach(string rucksack in rucksacks)
        {
            List<string> rucksackCompartments=GetRucksackCompartments(rucksack);
        }
        return result;
    }



    private List<string> GetRucksackCompartments(string oneRucksack) // A rekeszek szétválasztása
    {
        return new List<string>
        {
            oneRucksack.Substring(0, oneRucksack.Length / 2),
            oneRucksack.Substring(oneRucksack.Length / 2)
        };
    }
}
