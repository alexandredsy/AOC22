using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day9;

namespace TestProject1;

public class Day9Test
{
    private List<string> values;

    [SetUp]
    public void Setup()
    {
        values = new List<string>
        {
            "R 4",
            "U 4",
            "L 3",
            "D 1",
            "R 4",
            "D 1",
            "L 5",
            "R 2",
        };
    }

    [Test]
    public void DiagonalMouvements()
    {
        Day9.Solve1(new List<string>
        {
            "R 1",
            "U 2"
        }).Should().Be(2);
    }

    [Test]
    public void OnlyNewMouvements()
    {
        Day9.Solve1(new List<string>
        {
            "R 4",
            "L 4",
        }).Should().Be(4);
    }

    [Test]
    public void RegularMouvements()
    {
        Day9.Solve1(new List<string>
        {
            "U 4",
        }).Should().Be(4);
        Day9.Solve1(new List<string>
        {
            "L 4",
        }).Should().Be(4);
    }

    [Test]
    public void Validates1()
    {
        Day9.Solve1(values).Should().Be(13);
    }

    [Test]
    public void Solves1()
    {
        Day9.Solve1(InputHelper.GetLinesForDay(9)).Should().Be(6337);
    }

    [Test]
    public void Validates2()
    {
        Day9.Solve2(new List<string>()
        {
            "R 5",
            "U 8",
            "L 8",
            "D 3",
            "R 17",
            "D 10",
            "L 25",
            "U 20",
        }).Should().Be(36);
        Day9.Solve2(values).Should().Be(1);
    }

    [Test]
    public void Solves2()
    {
        Day9.Solve2(InputHelper.GetLinesForDay(9)).Should().Be(2455);
    }
}