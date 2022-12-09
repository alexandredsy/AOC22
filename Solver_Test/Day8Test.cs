using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day7;
using Solver.Day8;

namespace TestProject1;

public class Day8Test
{
    private List<string> values;

    [SetUp]
    public void Setup()
    {
        values = new List<string>
        {
            "30373",
            "25512",
            "65332",
            "33549",
            "35390",
        };
    }

    [Test]
    public void Validates1()
    {
        Day8.Solve1(values).Should().Be(21);
    }

    [Test]
    public void Solves1()
    {
        Day8.Solve1(InputHelper.GetLinesForDay(8)).Should().Be(1676);
    }

    [Test]
    public void Validates2()
    {
        Day8.Solve2(values).Should().Be(8);
    }

    [Test]
    public void Solves2()
    {
        Day8.Solve2(InputHelper.GetLinesForDay(8)).Should().Be(313200);
    }
}