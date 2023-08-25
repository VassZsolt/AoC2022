namespace AoC22.Day01;

public sealed class Day01Solver
{
    public string SolvePart1(string inputFileContent)
    {
        string[] caloriesList = inputFileContent.Split("\r\n");

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
        return "yoo2";
    }
}
