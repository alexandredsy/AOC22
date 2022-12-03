using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day2;

namespace TestProject1;

public class Day3Test
{
    private List<string> values;

    [SetUp]
    public void Setup()
    {
        values = new List<string>
        {
            "vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg",
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"
        };
    }

    [Test]
    public void Validates1()
    {
        Day3.Solve1(values).Should().Be(157);
    }

    [Test]
    public void Solves1()
    {
        Day3.Solve1(InputHelper.GetLinesForDay(3)).Should().Be(7793);
    }

    [Test]
    public void Validates2()
    {
        Day3.Solve2(values).Should().Be(70);
    }

    [Test]
    public void Solves2()
    {
        Day3.Solve2(InputHelper.GetLinesForDay(3)).Should().Be(2499);
    }
}