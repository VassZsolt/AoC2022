namespace AoC22.Day01;

public sealed class Day01Solver
{
    public string SolvePart1(string inputFileContent)
    {
        List<string> caloriesList = inputFileContent.Split("\r\n").ToList();
        caloriesList.Add(string.Empty);

        int sumOfCarryingCalories = 0, maxOfCarryingCalories = 0;
        foreach (string calories in caloriesList)
        {
            if (calories != string.Empty)
            {
                sumOfCarryingCalories += int.Parse(calories);
            }
            else
            {
                if (sumOfCarryingCalories > maxOfCarryingCalories)
                {
                    maxOfCarryingCalories = sumOfCarryingCalories;
                }
                sumOfCarryingCalories = 0;
            }
        }

        return maxOfCarryingCalories.ToString();
    }

    public string SolvePart2(string inputFileContent)
    {
        IReadOnlyList<Inventory> inventories = ParseInput(inputFileContent);
        int result = inventories
            .OrderByDescending(x => x.SumOfCalories)
            .Take(3)
            .Sum(x => x.SumOfCalories);

        return result.ToString();
    }

    private List<Inventory> ParseInput(string inputFileContent)
    {
        List<string> lines = inputFileContent.Split("\r\n").ToList();
        lines.Add(string.Empty);

        List<Inventory> result = new List<Inventory>();
        List<int> currentInventory = new List<int>();

        foreach (string calories in lines)
        {
            if (calories != string.Empty)
            {
                currentInventory.Add(int.Parse(calories));
            }
            else
            {
                result.Add(new Inventory(currentInventory));
                currentInventory = new List<int>();
            }
        }

        return result;
    }
}
