namespace AoC22.Day05;
public class Crate
{
    public char notation;
    public Crate(char notation) => this.notation = notation;
}
public class CrateTower
{
    public List<Crate> tower;

    public CrateTower(List<Crate> crates) => tower = crates; // Az utolsó elem lesz a legfelső elem!
    public void PlaceCrates(List<Crate> crates) => tower.AddRange(crates);
    private void RemoveTopNCrates(int n)
    {
        for (int i = 0; i < n; i++)
        {
            tower.RemoveAt(tower.Count - 1);
        }
    }
    public List<Crate> GetTopNCrates(int n)
    {
        List<Crate> result= new List<Crate>();
        for(int i = 0; i < n; i++)
        {
            result.Add(tower[tower.Count - 1]);
            RemoveTopNCrates(1);
        }
        return result;
    }
}
public class Warehouse
{
    public List<CrateTower> crateTowers;

    public Warehouse(List<CrateTower> crateTowers) => this.crateTowers = crateTowers;

    public void MoveCrates(int quantity, int from, int to)
    {
        crateTowers[to - 1].PlaceCrates(
            crateTowers[from - 1].GetTopNCrates(quantity));
    }
}
