namespace Solver.Day9;

public static class Day9
{
    public static int Solve1(List<string> input)
    {
        var positions = new List<Position>();
        var headPosition = new Position(0, 0);
        positions.Add(new Position(0, 0));
        foreach (var line in input)
        {
            var move = line.Split(" ");
            var direction = move[0];
            var count = int.Parse(move[1]);
            for (int i = 0; i < count; i++)
            {
                applyMove(direction, headPosition);
                positions.Add(calculateMove(headPosition, positions.Last()));
            }
        }

        return positions.GroupBy(p => $"{p.x},{p.y}").Distinct().Count();
    }

    public static int Solve2(List<string> input)
    {
        var positions = new List<Position>();
        var k1 = new Position(0, 0);
        var k2 = new Position(0, 0);
        var k3 = new Position(0, 0);
        var k4 = new Position(0, 0);
        var k5 = new Position(0, 0);
        var k6 = new Position(0, 0);
        var k7 = new Position(0, 0);
        var k8 = new Position(0, 0);
        var k9 = new Position(0, 0);
        positions.Add(new Position(0, 0));
        foreach (var line in input)
        {
            var move = line.Split(" ");
            var direction = move[0];
            var count = int.Parse(move[1]);
            for (var i = 0; i < count; i++)
            {
                applyMove(direction, k1);
                k2 = calculateMove(k1, k2);
                k3 = calculateMove(k2, k3);
                k4 = calculateMove(k3, k4);
                k5 = calculateMove(k4, k5);
                k6 = calculateMove(k5, k6);
                k7 = calculateMove(k6, k7);
                k8 = calculateMove(k7, k8);
                k9 = calculateMove(k8, k9);
                positions.Add(calculateMove(k9, positions.Last()));
                positions.Add(calculateMove(k9, positions.Last()));
            }
        }

        return positions.GroupBy(p => $"{p.x},{p.y}").Distinct().Count();
    }

    private static void applyMove(string direction, Position position)
    {
        switch (direction)
        {
            case "U":
                position.y += 1;
                break;
            case "D":
                position.y -= 1;
                break;
            case "L":
                position.x -= 1;
                break;
            case "R":
                position.x += 1;
                break;
        }
    }

    private static Position calculateMove(Position previousKnot, Position lastPosition)
    {
        var xDistance = previousKnot.x - lastPosition.x;
        var yDistance = previousKnot.y - lastPosition.y;

        if (Math.Abs(xDistance) == 2 && yDistance == 0)
            return new Position(lastPosition.x + xDistance / 2, lastPosition.y);

        if (Math.Abs(yDistance) == 2 && xDistance == 0)
            return new Position(lastPosition.x, lastPosition.y + yDistance / 2);


        if (Math.Abs(xDistance) == 2 && Math.Abs(yDistance) == 0)
            return new Position(lastPosition.x + xDistance / 2, lastPosition.y + yDistance / 2);

        if (Math.Abs(yDistance) == 2 && Math.Abs(xDistance) == 2)
            return new Position(lastPosition.x + +xDistance / 2, lastPosition.y + yDistance / 2);


        if (Math.Abs(xDistance) == 2 && yDistance != 0)
            return new Position(lastPosition.x + xDistance / 2, lastPosition.y + yDistance);

        if (Math.Abs(yDistance) == 2 && xDistance != 0)
            return new Position(lastPosition.x + xDistance, lastPosition.y + yDistance / 2);


        if (Math.Abs(yDistance) > 2)
            Console.WriteLine(33);
        return lastPosition;
    }


    private class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object? obj)
        {
            return x == ((Position)obj).x && y == ((Position)obj).y;
        }
    }
}