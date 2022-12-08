using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using Solver.Common;
using Solver.Day6;

namespace TestProject1;

public class Day6Test
{
    private List<string> values;

    [Test]
    public void Validates1()
    {
        Day6.Solve1("bvwbjplbgvbhsrlpgdmjqwftvncz").Should().Be(5);
        Day6.Solve1("nppdvjthqldpwncqszvftbrmjlhg").Should().Be(6);
        Day6.Solve1("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg").Should().Be(10);
        Day6.Solve1("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw").Should().Be(11);
        Day6.Solve1("mjqjpqmgbljsphdztnvjfqwrcgsmlb").Should().Be(7);
    }

    [Test]
    public void Solves1()
    {
        Day6.Solve1(InputHelper.GetLinesForDay(6).First()).Should().Be(1198);
    }

    [Test]
    public void Validates2()
    {
        Day6.Solve2("mjqjpqmgbljsphdztnvjfqwrcgsmlb").Should().Be(19);
        Day6.Solve2("bvwbjplbgvbhsrlpgdmjqwftvncz").Should().Be(23);
        Day6.Solve2("nppdvjthqldpwncqszvftbrmjlhg").Should().Be(23);
        Day6.Solve2("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg").Should().Be(29);
        Day6.Solve2("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw").Should().Be(26);
    }

    [Test]
    public void Solves2()
    {
        Day6.Solve2(InputHelper.GetLinesForDay(6).First()).Should().Be(3120);
    }
}