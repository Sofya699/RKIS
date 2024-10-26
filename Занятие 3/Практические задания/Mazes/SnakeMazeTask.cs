namespace Mazes;

public static class SnakeMazeTask
{
public static class SnakeMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            var steps = width - 3;
            while (true)
            {
                MoveTo("right", robot, steps);
                MoveTo("down", robot);
                MoveTo("left", robot, steps);
                if (robot.Finished) break;
                MoveTo("down", robot);
            }
        }

        private static void MoveTo(string direction, Robot robot, int steps ? )
        {
            if (direction == "right")
            {
                for (var i = 0; i < steps; i++)
                {
                    robot.MoveTo(Direction.Right);
                }
            }
            if (direction == "left")
            {
                for (var i = 0; i < steps; i++)
                {
                    robot.MoveTo(Direction.Left);
                }
            }
            if (direction == "down")
            {
                for (var i = 0; i < 2; i++)
                {
                    robot.MoveTo(Direction.Down);
                }
            }
        }
}
