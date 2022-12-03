using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day1;

namespace TestProject1;

public class Day1Test
{
    private List<string> values = new()
        { "1000", "2000", "3000", "", "4000", "", "5000", "6000", "", "7000", "8000", "9000", "", "10000" };

    [Test]
    public void Validates1()
    {
        Day1.Solve1(values).Should().Be(24000);
    }

    [Test]
    public void Solves1()
    {
        Day1.Solve1(InputHelper.GetLinesForDay(1)).Should().Be(70509);
    }

    [Test]
    public void Validates2()
    {
        Day1.Solve2(values).Should().Be(45000);
    }

    [Test]
    public void Solves2()
    {
        Day1.Solve2(InputHelper.GetLinesForDay(1)).Should().Be(208567);
    }
}