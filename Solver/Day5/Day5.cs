using System.Text.RegularExpressions;

namespace Solver.Day5;

public static class Day5
{
    public static string Solve1(List<string> input)
    {
        var stacks = ParseStacks(input);
        var instructions = ParseInstructions(input);
        foreach (var instruction in instructions)
        {
            for (int i = 0; i < instruction[0]; i++)
            {
                stacks[instruction[2] - 1].Push(stacks[instruction[1] - 1].Pop());
            }
        }

        return string.Join("", stacks.Select(s => s.Peek()).ToList());
    }

    public static string Solve2(IEnumerable<string> input)
    {
        var stacks = ParseStacks(input);
        var instructions = ParseInstructions(input);
        foreach (var instruction in instructions)
        {
            var transition = new Stack<char>();
            for (var i = 0; i < instruction[0]; i++)
            {
                transition.Push(stacks[instruction[1] - 1].Pop());
            }

            while (transition.Count > 0)
            {
                stacks[instruction[2] - 1].Push(transition.Pop());
            }
        }

        return string.Join("", stacks.Select(s => s.Peek()).ToList());
    }

    private static List<Stack<char>> ParseStacks(IEnumerable<string> input)
    {
        var stackCount = GetStackCount(input);
        var stacks = new List<Stack<char>>();
        for (var i = 0; i < stackCount; i++)
        {
            stacks.Add(new Stack<char>());
        }

        foreach (var line in input)
        {
            if (line == string.Empty) break;
            var currentStack = 0;
            var chars = line.ToCharArray();

            for (var i = 0; i < stackCount; i++)
            {
                var index = (i + 1) * 4 - 3;
                if (chars.Length > index && chars[index] != ' ') stacks[i].Push(chars[index]);
            }
        }

        stacks.ForEach(Reverse);
        return stacks;
    }

    static void Reverse(Stack<char> stack)
    {
        if (stack.Count == 0)
            return;

        char element = stack.Pop();
        Reverse(stack);
        InsertAndRearrange(stack, element);
    }

    static void InsertAndRearrange(Stack<char> stack, char element)
    {
        if (stack.Count == 0)
            stack.Push(element);
        else
        {
            char temp = stack.Pop();
            InsertAndRearrange(stack, element);
            stack.Push(temp);
        }
    }

    private static List<List<int>> ParseInstructions(IEnumerable<string> input)
    {
        var moveEx = new Regex("(?<=move).[0-9]+");
        var source = new Regex("(?<=from).[0-9]+");
        var target = new Regex("(?<=to).[0-9]+");
        var instructions = input.Where(s => s.StartsWith("move")).ToList().Select(instruction => new List<int>()
        {
            int.Parse(moveEx.Match(instruction).Value),
            int.Parse(source.Match(instruction).Value),
            int.Parse(target.Match(instruction).Value),
        }).ToList();

        return instructions;
    }

    private static int GetStackCount(IEnumerable<string> input)
    {
        return int.Parse(input.TakeWhile(x => x != String.Empty).Last().Trim().ToCharArray().Last().ToString());
    }
}