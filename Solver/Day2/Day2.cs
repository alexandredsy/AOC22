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
        foreach (var s in input)
        {
            var match = s.Split(" ");

            points += PointsForRound(match);
            points += PointsForChoice(match[1].toChoice());
        }

        return points;
    }

    public static int Solve2(IEnumerable<string> input)
    {
        var points = 0;
        foreach (var s in input)
        {
            var match = s.Split(" ");

            points += match[1] switch
            {
                "X" => 0,
                "Y" => 3,
                "Z" => 6
            };
            points += PointsForChoice2(match);
        }

        return points;
    }

    private static int PointsForChoice2(string[] match)
    {
        return match[1] switch
        {
            "X" => PointsForChoice(loosingTo(match[0]).toChoice()),
            "Y" => PointsForChoice(match[0].toChoice()),
            "Z" => PointsForChoice(winningOver(match[0]).toChoice()),
        };
    }

    private static string winningOver(string s)
    {
        return s switch
        {
            "A" => "B",
            "B" => "C",
            "C" => "A",
        };
    }

    private static string loosingTo(string s)
    {
        return s switch
        {
            "B" => "A",
            "C" => "B",
            "A" => "C",
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

    private static int PointsForRound(string[] match)
    {
        var opponent = match[0];
        var me = match[1];
        switch (me)
        {
            case "X":
                switch (opponent)
                {
                    case "A":
                        return 3;
                    case "B":
                        return 0;
                    case "C":
                        return 6;
                }

                break;
            case "Y":
                switch (opponent)
                {
                    case "A":
                        return 6;
                    case "B":
                        return 3;
                    case "C":
                        return 0;
                }

                break;
            case "Z":
                switch (opponent)
                {
                    case "A":
                        return 0;
                    case "B":
                        return 6;
                    case "C":
                        return 3;
                }

                break;
        }

        throw new Exception("Marche pas");
    }

    private static Choice toChoice(this string input)
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
}