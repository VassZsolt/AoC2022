namespace AoC22.Day05;
public class Crate
{
    public char notation;
    public Crate(char notation) => this.notation = notation;
}
public class CrateTower
{
    public List<Crate> crates;

    public CrateTower(List<Crate> crates) => this.crates = crates; // Az utolsó elem lesz a legfelső elem!
    public void PlaceCrate(Crate crate) => crates.Add(crate);
    public void RemoveTopCrate() => crates.RemoveAt(crates.Count - 1);
    public Crate GetTopCrate() => crates[crates.Count - 1];
}
public class Warehouse
{
    public List<CrateTower> crateTowers;

    public Warehouse(List<CrateTower> crateTowers) => this.crateTowers = crateTowers;

    public void MoveCrate(int from, int to)
    {
        crateTowers[to - 1].PlaceCrate(
            crateTowers[from - 1].GetTopCrate());
        crateTowers[from - 1].RemoveTopCrate();
    }
}
