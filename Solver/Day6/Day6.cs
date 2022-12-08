namespace Solver.Day6;

public static class Day6
{
    public static int Solve1(string input)
    {
        return Solve(input, 4);
    }

    public static int Solve2(string input)
    {
        return Solve(input, 14);
    }

    private static int Solve(string input, int length)
    {
        for (int i = 0; i < input.Length; i++)
        {
            var subset = input.Substring(i, length);
            if (subset.ToCharArray().Distinct().Count() == length) return i + length;
        }

        throw new Exception("Marches pas :(");
    }
}