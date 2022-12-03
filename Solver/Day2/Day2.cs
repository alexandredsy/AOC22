namespace Solver.Day2;

public static class Day2
{
    private enum Choice
    {
        Rock,
        Paper,
        Scissor
    }

    public static int Solve1(IEnumerable<string> input)
    {
        var points = 0;
        var matches = input.Select(i => new Match()
            { Opponent = i.Split(" ")[0].AsChoice(), Answer = i.Split(" ")[1] });
        foreach (var match in matches)
        {
            points += PointsForRound(match);
            points += PointsForChoice(match.Answer.AsChoice());
        }

        return points;
    }

    public static int Solve2(IEnumerable<string> input)
    {
        var points = 0;
        var matches = input.Select(i => new Match()
            { Opponent = i.Split(" ")[0].AsChoice(), Answer = i.Split(" ")[1] });
        foreach (var match in matches)
        {
            points += match.Answer switch
            {
                "X" => 0,
                "Y" => 3,
                "Z" => 6
            };
            points += PointsForChoice2(match);
        }

        return points;
    }

    private static int PointsForChoice2(Match match)
    {
        return match.Answer switch
        {
            "X" => PointsForChoice(LoosingTo(match.Opponent)),
            "Y" => PointsForChoice(match.Opponent),
            "Z" => PointsForChoice(WinningOver(match.Opponent))
        };
    }

    private static Choice WinningOver(Choice s)
    {
        return s switch
        {
            Choice.Rock => Choice.Paper,
            Choice.Paper => Choice.Scissor,
            Choice.Scissor => Choice.Rock,
        };
    }

    private static Choice LoosingTo(Choice s)
    {
        return s switch
        {
            Choice.Paper => Choice.Rock,
            Choice.Scissor => Choice.Paper,
            Choice.Rock => Choice.Scissor,
        };
    }

    private static int PointsForChoice(Choice choice)
    {
        return choice switch
        {
            Choice.Rock => 1,
            Choice.Paper => 2,
            Choice.Scissor => 3,
        };
    }

    private static int PointsForRound(Match match)
    {
        return match.Answer.AsChoice() switch
        {
            Choice.Rock when match.Opponent == Choice.Rock => 3,
            Choice.Rock when match.Opponent == Choice.Paper => 0,
            Choice.Rock when match.Opponent == Choice.Scissor => 6,
            Choice.Paper when match.Opponent == Choice.Rock => 6,
            Choice.Paper when match.Opponent == Choice.Paper => 3,
            Choice.Paper when match.Opponent == Choice.Scissor => 0,
            Choice.Scissor when match.Opponent == Choice.Rock => 0,
            Choice.Scissor when match.Opponent == Choice.Paper => 6,
            Choice.Scissor when match.Opponent == Choice.Scissor => 3,
        };
    }

    private static Choice AsChoice(this string input)
    {
        return input switch
        {
            "A" => Choice.Rock,
            "B" => Choice.Paper,
            "C" => Choice.Scissor,
            "X" => Choice.Rock,
            "Y" => Choice.Paper,
            "Z" => Choice.Scissor,
        };
    }

    private class Match
    {
        public Choice Opponent;
        public string Answer;
    }
}