namespace Mazes;

public static class EmptyMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            MoveTo('x', robot, width);
        }

        private static void MoveTo(string direction, Robot robot, int coords)
        {
            if (direction == 'x')
            {
                while (robot.X != (coords - 2))
                {
                    robot.MoveTo(Direction.Right);
                }
            }
            else if (direction == 'y')
            {
                while (robot.Y != (coords - 2))
                {
                    robot.MoveTo(Direction.Down);
                }
            }
        }
}
