using System.Text;

namespace AoC22.Day04;

public class Day04Solver
{
    public string SolvePart1(string inputFileContent) // Az egymást fedő halmazok száma (count)
    {
        List<string> sectionPairs = SplitToList(inputFileContent, "\r\n"); // Minden sor egy tartomány párt határoz meg
        int counter = 0;
        foreach (string sectionPair in sectionPairs)
        {
            if (IsOneSectionCompletlyContainsTheOther(sectionPair))
            {
                counter++;
            }
        }
        return counter.ToString();
    }
    private List<string> SplitToList(string input, string separator)
    {
        return input
             .Split(separator, StringSplitOptions.RemoveEmptyEntries)
             .ToList();
    }

    private bool IsOneSectionCompletlyContainsTheOther(string sectionPair)
    {
        List<string> sections = SplitToList(sectionPair, ","); // Minden tartomány pár felbontható tartományokra (egyes elfek ezek mentén takarítanak)
        List<string> openedSectionA = RepleceSectionsToNumbers(sections[0]);
        List<string> openedSectionB = RepleceSectionsToNumbers(sections[1]);

        if (CalculateDifference(openedSectionA, openedSectionB).Count == 0
            || CalculateDifference(openedSectionB, openedSectionA).Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private List<string> RepleceSectionsToNumbers(string section) //Visszaadja a tartományt az elemeik felsorolásával
    {
        List<string> sectionItems = new List<string>();
        List<string> startAndEnd = SplitToList(section, "-"); // Meghatározzuk a tartomány kezdetét és végét

        for (int i = int.Parse(startAndEnd[0]); i < int.Parse(startAndEnd[1]) + 1; i++)
        {
            sectionItems.Add(i.ToString());
        }
        return sectionItems;
    }

    private List<string> CalculateDifference(List<string> setA, List<string> setB) // A két halmaz különbsége (A\B)
    {
        HashSet<string> difference = new HashSet<string>(setA);
        difference.ExceptWith(setB);
        return difference.ToList();
    }

    public string SolvePart2(string inputFileContent)
    {
        List<string> sectionPairs = SplitToList(inputFileContent, "\r\n"); // Minden sor egy tartomány párt határoz meg
        int counter = 0;
        foreach (string sectionPair in sectionPairs)
        {
            if (IsOneSectionOverlapTheOther(sectionPair))
            {
                counter++;
            }
        }
        return counter.ToString();
    }
    private bool IsOneSectionOverlapTheOther(string sectionPair)
    {
        List<string> sections = SplitToList(sectionPair, ","); // Minden tartomány pár felbontható tartományokra (egyes elfek ezek mentén takarítanak)
        List<string> openedSectionA = RepleceSectionsToNumbers(sections[0]);
        List<string> openedSectionB = RepleceSectionsToNumbers(sections[1]);

        if (CalculateIntersection(openedSectionA, openedSectionB).Count != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private List<string> CalculateIntersection(List<string> setA, List<string> setB) // A két halmaz metszete
    {
        HashSet<string> intersection = new HashSet<string>(setA);
        intersection.IntersectWith(setB);
        return intersection.ToList();
    }
}
