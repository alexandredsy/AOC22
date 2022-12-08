namespace Solver.Day4;

public class Day4
{
    public static int Solve1(IEnumerable<string> input)
    {
        var slackinElfCount = 0;
        foreach (var line in input)
        {
            var sections = line.Split(",");
            var s1 = BuildSection(sections[0]);
            var s2 = BuildSection(sections[1]);
            var overlap = Getoverlap(s1, s2);
            if (s1.Intersect(overlap).ToList().Count == s1.Count || s2.Intersect(overlap).ToList().Count == s2.Count)
                slackinElfCount++;
        }

        return slackinElfCount;
    }

    public static int Solve2(IEnumerable<string> input)
    {
        var count = 0;
        foreach (var line in input)
        {
            var sections = line.Split(",");
            var s1 = BuildSection(sections[0]);
            var s2 = BuildSection(sections[1]);
            var overlap = Getoverlap(s1, s2);
            if (overlap.Count >0) count++;
        }

        return count;
    }

    private static List<int> Getoverlap(List<int> s1, List<int> s2)
    {
        return s1.Intersect(s2).ToList();
    }

    private static List<int> BuildSection(string elf)
    {
        var section = new List<int>();
        var start = int.Parse(elf.Split("-")[0]);
        var end = int.Parse(elf.Split("-")[1]);
        for (var i = 0; i < 100; i++)
        {
            if (i >= start) section.Add(i);
            if (i == end) return section;
        }

        return section;
    }
}