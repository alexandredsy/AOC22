namespace Solver.Day1;

public static class Day1
{
    public static int Solve1(IEnumerable<string> input)
    {
        return Solve(input).Max();
    }

    public static int Solve2(IEnumerable<string> input)
    {
        return Solve(input).OrderByDescending(e => e).Chunk(3).First().Sum();
    }

    private static IEnumerable<int> Solve(IEnumerable<string> lines)
    {
        var elves = new List<int>();
        var currentElfCalories = 0;
        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                elves.Add(currentElfCalories);
                currentElfCalories = 0;
            }
            else
            {
                currentElfCalories += int.Parse(line);
            }
        }
        elves.Add(currentElfCalories);

        return elves;
    }
}