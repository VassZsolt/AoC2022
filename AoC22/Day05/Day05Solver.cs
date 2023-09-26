namespace AoC22.Day05;
public class Day05Solver
{
    public string SolvePart1(string inputFileContent)
    {
        return "";
    }
    public string SolvePart2(string inputFileContent)
    {

        return "";
    }
    public Warehouse GenerateWarehouseStartState()
    {
        Warehouse warehouse = new Warehouse(
            new List<CrateTower>
            {
                new CrateTower(
                    new List<Crate> // 1. oszlop
                    {
                        new Crate('F'),
                        new Crate('H'),
                        new Crate('B'),
                        new Crate('V'),
                        new Crate('R'),
                        new Crate('Q'),
                        new Crate('D'),
                        new Crate('P')
                    }),

                new CrateTower(
                    new List<Crate> // 2. oszlop
                    {
                        new Crate('L'),
                        new Crate('D'),
                        new Crate('Z'),
                        new Crate('Q'),
                        new Crate('W'),
                        new Crate('V')
                    }),

                new CrateTower(
                    new List<Crate> // 3. oszlop
                    {
                        new Crate('H'),
                        new Crate('L'),
                        new Crate('Z'),
                        new Crate('Q'),
                        new Crate('G'),
                        new Crate('R'),
                        new Crate('P'),
                        new Crate('C')
                    }),

                new CrateTower(
                    new List<Crate> // 4. oszlop
                    {
                        new Crate('R'),
                        new Crate('D'),
                        new Crate('H'),
                        new Crate('F'),
                        new Crate('J'),
                        new Crate('V'),
                        new Crate('B')
                    }),

                new CrateTower(
                    new List<Crate> // 5. oszlop
                    {
                        new Crate('Z'),
                        new Crate('W'),
                        new Crate('L'),
                        new Crate('C')
                    }),

                new CrateTower(
                    new List<Crate> // 6. oszlop
                    {
                        new Crate('J'),
                        new Crate('R'),
                        new Crate('P'),
                        new Crate('N'),
                        new Crate('T'),
                        new Crate('G'),
                        new Crate('V'),
                        new Crate('M')
                    }),

                new CrateTower(
                    new List<Crate> // 7. oszlop
                    {
                        new Crate('J'),
                        new Crate('R'),
                        new Crate('L'),
                        new Crate('V'),
                        new Crate('M'),
                        new Crate('B'),
                        new Crate('S')
                    }),

                new CrateTower(
                    new List<Crate> // 8. oszlop
                    {
                        new Crate('D'),
                        new Crate('P'),
                        new Crate('J')
                    }),

                new CrateTower(
                    new List<Crate> // 9. oszlop
                    {
                        new Crate('D'),
                        new Crate('C'),
                        new Crate('N'),
                        new Crate('W'),
                        new Crate('V')
                    }),
            });

        return warehouse;

    }
}
