namespace Solver.Common;

public static class InputHelper
{
    public static List<string> GetLinesForDay(int day)
    {
        return File.ReadLines($@"C:\Users\Alex\RiderProjects\AOC22\Solver\Day{day}\input.txt").ToList();
    }
}