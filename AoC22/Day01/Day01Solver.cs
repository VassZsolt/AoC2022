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
        List<string> caloriesList = inputFileContent.Split("\r\n").ToList();
        caloriesList.Add(string.Empty);

        List<int> amountOfCarriedCalories = new List<int>();
        int sumOfCarryingCalories = 0;

        foreach (string calories in caloriesList)
        {
            if (calories != string.Empty)
            {
                sumOfCarryingCalories += int.Parse(calories);
            }
            else
            {
                amountOfCarriedCalories.Add(sumOfCarryingCalories);
                sumOfCarryingCalories = 0;
            }
        }

        amountOfCarriedCalories.Sort();
        amountOfCarriedCalories.Reverse();

        int sumOfTop3CarryingCalories = 0;
        for (int i = 0; i < 3; i++)
        {
            sumOfTop3CarryingCalories += amountOfCarriedCalories[i];
        }

        return sumOfTop3CarryingCalories.ToString();
    }
}
