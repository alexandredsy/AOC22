using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day2;
using Solver.Day3;
using Solver.Day4;

namespace TestProject1;

public class Day4Test
{
    private List<string> values;

    [SetUp]
    public void Setup()
    {
        values = new List<string>
        {
            "2-4,6-8",
            "2-3,4-5",
            "5-7,7-9",
            "2-8,3-7",
            "6-6,4-6",
            "2-6,4-8",
        };
    }

    [Test]
    public void Validates1()
    {
        Day4.Solve1(values).Should().Be(2);
    }

    [Test]
    public void Solves1()
    {
        Day4.Solve1(InputHelper.GetLinesForDay(4)).Should().Be(532);
    }

    [Test]
    public void Validates2()
    {
        Day4.Solve2(values).Should().Be(4);
    }

    [Test]
    public void Solves2()
    {
        Day4.Solve2(InputHelper.GetLinesForDay(4)).Should().Be(854);
    }
}