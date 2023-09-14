using System.Text;

namespace AoC22.Day03;

public class Day03Solver
{
    public string SolvePart1(string inputFileContent) // A prioritások össszege
    {
        List<string> rucksacks = inputFileContent
            .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int sum = 0;
        foreach (string rucksack in rucksacks)
        {
            List<string> rucksackCompartments = GetRucksackCompartments(rucksack);
            char sharedItem = SharedItemBetweenCompartments(rucksackCompartments);
            sum += ItemPriority(sharedItem);
        }
        return sum.ToString();
    }

    private int ItemPriority(char item) // Az adott item prioritása
    {
        if (IsLowerCase(item))
        {
            return (int)item - 96; // Kisbetűk esetén a prioritás értéke 1-26
        }
        else // Feltételezzük hogy ami nem kisbetűs az nagybetűs
        {
            return (int)item - 38; // Nagybetűk esetén a prioritás értéke 27-52
        }
    }

    private bool IsLowerCase(char letter)
    {
        return (int)letter > 96 && (int)letter < 123;
    }

    private char SharedItemBetweenCompartments(List<string> rucksackCompartments) // A rekeszek közös tartalma
    {
        foreach (char item in rucksackCompartments[0])
        {
            if (rucksackCompartments[1].Contains(item))
            {
                return item;
            }
        }
        return ' ';
    }

    private static List<string> GetRucksackCompartments(string oneRucksack) // A rekeszek szétválasztása
    {
        return new List<string>
        {
            oneRucksack.Substring(0, oneRucksack.Length / 2),
            oneRucksack.Substring(oneRucksack.Length / 2)
        };
    }

    public string SolvePart2(string inputFileContent)
    {
        List<string> rucksacks = inputFileContent
            .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int sum = 0;

        for(int i=2; i< rucksacks.Count; i+=3)
        {
            char sharedItem = SharedItemBetweenRucksacks(new List<string>
            {
                rucksacks[i-2],
                rucksacks[i-1],
                rucksacks[i]
            });
            sum += ItemPriority(sharedItem);
        }

        return sum.ToString();
    }

    private char SharedItemBetweenRucksacks(List<string> rucksacks) // A hátizsákok közös tartalma
    {
        foreach (char item in rucksacks[0])
        {
            if (rucksacks[1].Contains(item) && rucksacks[2].Contains(item))
            {
                return item;
            }
        }
        return ' ';
    }
}
