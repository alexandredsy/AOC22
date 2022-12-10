namespace Solver.Day10;

public static class Day10
{
    private const int LineWidth = 40;

    public static int Solve1(List<string> input)
    {
        var valueInTime = GetValueInTime(input);

        return ValueAtTime(valueInTime, 20) * 20 +
               ValueAtTime(valueInTime, 60) * 60 +
               ValueAtTime(valueInTime, 100) * 100 +
               ValueAtTime(valueInTime, 140) * 140 +
               ValueAtTime(valueInTime, 180) * 180 +
               ValueAtTime(valueInTime, 220) * 220;
    }

    private static int ValueAtTime(List<int> valueInTime, int time)
    {
        if (time == 0) return 1;
        var currentIteration = 0;
        var count = 0;
        for (var i = 0; i < valueInTime.Count; i++)
        {
            if (valueInTime[i] == 0)
                currentIteration++;
            else
            {
                currentIteration++;
            }

            count += valueInTime[i];
            if (time == currentIteration) break;
        }

        return count;
    }

    public static int Solve2(List<string> input)
    {
        var valueInTime = GetValueInTime(input);
        for (int i = 0; i < 240; i++)
        {
            if (i % LineWidth == 0 && i != 0) Console.WriteLine();
            var aa = ValueAtTime(valueInTime, i+1);
            if (i % LineWidth == aa || i % LineWidth == aa - 1 || i % LineWidth == aa + 1)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(".");
            }
        }

        return 1;
    }

    private static List<int> GetValueInTime(List<string> input)
    {
        var valueInTime = new List<int>() { 1 };
        foreach (var action in input)
        {
            if (action == "noop")
            {
                valueInTime.Add(0);
            }
            else
            {
                valueInTime.Add(0);
                valueInTime.Add(int.Parse(action.Split(" ")[1]));
            }
        }

        return valueInTime;
    }
}