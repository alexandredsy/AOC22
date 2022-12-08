using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day4;
using Solver.Day5;

namespace TestProject1;

public class Day5Test
{
    private List<string> values;

    [SetUp]
    public void Setup()
    {
        values = new List<string>
        {
            "    [D]",
            "[N] [C]",
            "[Z] [M] [P]",
            "1   2   3",
            "",
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2",
        };
    }

    [Test]
    public void Validates1()
    {
        Day5.Solve1(values).Should().Be("CMZ");
    }

    [Test]
    public void Solves1()
    {
        Day5.Solve1(InputHelper.GetLinesForDay(5)).Should().Be("TDCHVHJTG");
    }

    [Test]
    public void Validates2()
    {
        Day5.Solve2(values).Should().Be("MCD");
    }

    [Test]
    public void Solves2()
    {
        Day5.Solve2(InputHelper.GetLinesForDay(5)).Should().Be("NGCMPJLHV");
    }
}