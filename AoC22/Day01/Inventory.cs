namespace AoC22.Day01;

internal sealed class Inventory
{
    private readonly IEnumerable<int> itemCalories;
    internal int SumOfCalories => itemCalories.Sum();

    internal Inventory(IEnumerable<int> itemCalories)
    {
        this.itemCalories = itemCalories.ToList();
    }
}
