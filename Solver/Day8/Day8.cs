﻿namespace Solver.Day8;

public static class Day8
{
    public static int Solve1(List<string> input)
    {
        var count = 0;
        var array = ToIntArray(input);
        var edge = CountEdge(input);

        for (var i = 1; i < array.Count - 1; i++)
        {
            for (var j = 1; j < array[0].Count - 1; j++)
            {
                if (!ifBiggestInRow(i, j, array)) count++;
            }
        }

        return count + edge;
    }

    private static bool ifBiggestInRow(int x, int y, List<List<int>> array)
    {
        return LookLeft(x, y, array) && LookRight(x, y, array) & LookUp(x, y, array) && LookDown(x, y, array);
    }

    private static bool LookRight(int x, int y, List<List<int>> array)
    {
        for (var i = x + 1; i < array[0].Count; i++)
        {
            if (array[i][y] >= array[x][y]) return true;
        }

        return false;
    }

    private static bool LookUp(int x, int y, List<List<int>> array)
    {
        for (var i = 0; i < y; i++)
        {
            if (array[x][i] >= array[x][y]) return true;
        }

        return false;
    }

    private static bool LookDown(int x, int y, List<List<int>> array)
    {
        for (var i = y + 1; i < array.Count; i++)
        {
            if (array[x][i] >= array[x][y]) return true;
        }

        return false;
    }

    private static bool LookLeft(int x, int y, List<List<int>> array)
    {
        var count = 0;
        for (var i = 0; i < x; i++)
        {
            if (array[i][y] >= array[x][y]) return true;
        }

        return false;
    }

    private static List<List<int>> ToIntArray(List<string> input)
    {
        return input.Select(line => line.ToCharArray().Select(e => int.Parse(e.ToString())).ToList()).ToList();
    }

    public static int Solve2(List<string> input)
    {
        return 1;
    }

    private static int CountEdge(List<string> input)
    {
        return input.Count * 2 + input[0].Length * 2 - 4;
    }
}