namespace Solver.Day2;

public class Day3
{
    public static void Run()
    {
        var input = File.ReadLines(@"C:\Users\Alex\RiderProjects\AOC22\Solver\Day3\input.txt");
        Console.WriteLine(Solve1(input)); //7793
        Console.WriteLine(Solve2(input));
    }

    public static int Solve1(IEnumerable<string> input)
    {
        return input.Select(s => GetCommon(GetCompartiments(s))).Sum(c => GetValueForChar(c));
    }

    public static int Solve2(IEnumerable<string> input)
    {
        var badges = input.Chunk(3).Select(e => GetCommon(e));
        return badges.Sum(b => GetValueForChar(b));
    }

    private static int GetValueForChar(int c)
    {
        if (c > 96) return c - 96;
        return c - 64 + 26;
    }

    private static char GetCommon(string[] compartiments)
    {
        foreach (var c in compartiments[0].ToCharArray())
        {
            var isInAll = true;
            foreach (var compartiment in compartiments)
            {
                if (!compartiment.ToCharArray().Contains(c)) isInAll = false;
            }

            if (isInAll) return c;
        }

        return '\0';
    }


    private static string[] GetCompartiments(string input)
    {
        return new[] { input.Substring(0, input.Length / 2), input.Substring(input.Length / 2, input.Length / 2) };
    }
}