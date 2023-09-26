using AoC22.Day05;
using FluentAssertions;

namespace AoC22.Test.Day05;
public class Day05Tests
{
    [Fact]
    public void VerifyWarehouseMoveMethod()
    {
        Warehouse warehouse = new Warehouse(
            new List<CrateTower>
            {
                new CrateTower(
                    new List<Crate> // 1. oszlop
                    {
                        new Crate('Z'),
                        new Crate('N')
                    }),

                new CrateTower(
                    new List<Crate> // 2. oszlop
                    {
                        new Crate('M'),
                        new Crate('C'),
                        new Crate('D')
                    }),

                new CrateTower(
                    new List<Crate> // 3. oszlop
                    {
                        new Crate('P')

                    }),
            });
        warehouse.MoveCrate(2, 1);

        Warehouse resultWarehouse = new Warehouse(
            new List<CrateTower>
            {
                new CrateTower(
                    new List<Crate> // 1. oszlop
                    {
                        new Crate('Z'),
                        new Crate('N'),
                        new Crate('D')
                    }),

                new CrateTower(
                    new List<Crate> // 2. oszlop
                    {
                        new Crate('M'),
                        new Crate('C')
                    }),

                new CrateTower(
                    new List<Crate> // 3. oszlop
                    {
                        new Crate('P')
                    }),
             });

        warehouse.Should().BeEquivalentTo(resultWarehouse);
    }
}
