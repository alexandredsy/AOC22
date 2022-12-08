using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day7;

namespace TestProject1;

public class Day7Test
{
    private List<string> values;
    private Day7 solver;

    [SetUp]
    public void Setup()
    {
        solver = new Day7();
        values = new List<string>
        {
            "$ cd /",
            "$ ls",
            "dir a",
            "14848514 b.txt",
            "8504156 c.dat",
            "dir d",
            "$ cd a",
            "$ ls",
            "dir e",
            "29116 f",
            "2557 g",
            "62596 h.lst",
            "$ cd e",
            "$ ls",
            "584 i",
            "$ cd ..",
            "$ cd ..",
            "$ cd d",
            "$ ls",
            "4060174 j",
            "8033020 d.log",
            "5626152 d.ext",
            "7214296 k",
        };
    }

    [Test]
    public void Validates1()
    {
        solver.Solve1(values).Should().Be(95437);
    }

    [Test]
    public void Solves1()
    {
        solver.Solve1(InputHelper.GetLinesForDay(7)).Should().Be(1141028);
    }

    [Test]
    public void Validates2()
    {
        solver.Solve2(values).Should().Be(24933642);
    }

    [Test]
    public void Solves2()
    {
        solver.Solve2(InputHelper.GetLinesForDay(7)).Should().Be(8278005);
    }
}