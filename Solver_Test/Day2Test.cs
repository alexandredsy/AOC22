using System.Collections.Generic;
using Solver.Day2;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;

namespace TestProject1;

public class Day2Test
{
    private List<string> values = new() { "A Y", "B X", "C Z" };

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Validates1()
    {
        Day2.Solve1(values).Should().Be(15);
    }

    [Test]
    public void Solves1()
    {
        Day2.Solve1(InputHelper.GetLinesForDay(2)).Should().Be(11767);
    }

    [Test]
    public void Validates2()
    {
        Day2.Solve2(values).Should().Be(12);
    }

    [Test]
    public void Solves2()
    {
        Day2.Solve2(InputHelper.GetLinesForDay(2)).Should().Be(13886);
    }
}