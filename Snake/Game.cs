using System.Diagnostics;

namespace Snake
{
    class Game
    {
        public List<Point> Snake = new List<Point>();

        public Game()
        {
            Snake.Add(new Point() { X = 200, Y = 200 });
        }
        public void Up()
        {
            for (int i = 0; i < Snake.Count; i++)
            {
                if (Snake[i].Y - 10 < 0)
                {
                    Snake[i] = new Point() { X = Snake[Snake.Count - 1].X, Y = 440 };
                }
                Snake[i] = new Point() { X = Snake[Snake.Count - 1].X, Y = Snake[Snake.Count - 1].Y - 10 };
            }
        }
        public void Down()
        {
            for (int i = 0; i < Snake.Count; i++)
            {
                if (Snake[i].Y + 10 > 440)
                {
                    Snake[i] = new Point() { X = Snake[Snake.Count - 1].X, Y = 0 };
                }
                Snake[i] = new Point() { X = Snake[Snake.Count - 1].X, Y = Snake[Snake.Count - 1].Y + 10 };
            }
        }
        public void Left()
        {
            for (int i = 0; i < Snake.Count; i++)
            {
                if (Snake[i].X - 10 < 0)
                {
                    Snake[i] = new Point() { X = 800, Y = Snake[Snake.Count - 1].Y };
                }
                Snake[i] = new Point() { X = Snake[Snake.Count - 1].X - 10, Y = Snake[Snake.Count - 1].Y };
            }
        }
        public void Right()
        {
            for (int i = 0; i < Snake.Count; i++)
            {
                if (Snake[i].X + 10 > 800)
                {
                    Snake[i] = new Point() { X = 0, Y = Snake[Snake.Count - 1].Y };
                }
                Snake[i] = new Point() { X = Snake[Snake.Count - 1].X + 10, Y = Snake[Snake.Count - 1].Y };
            }
        }

        public bool CheckCollision(Rectangle apple, Rectangle snake, ref int score, int lastInput)
        {
            Debug.Write(snake.X + " : " + snake.Y + "\n");
            if (apple.X == snake.X && apple.Y == snake.Y)
            {
                score++;
                AddTail(snake, lastInput);
                return true;
            }
            else
                return false;
        }

        private void AddTail(Rectangle snake, int lastInput)
        {
            if (lastInput == 0)
                Snake.Add(new Point() { X = Snake[Snake.Count - 1].X, Y = Snake[Snake.Count - 1].Y - snake.Height });
            if (lastInput == 1)
                Snake.Add(new Point() { X = Snake[Snake.Count - 1].X, Y = Snake[Snake.Count - 1].Y + snake.Height });
            if (lastInput == 2)
                Snake.Add(new Point() { X = Snake[Snake.Count - 1].X - snake.Width, Y = Snake[Snake.Count - 1].Y });
            if (lastInput == 3)
                Snake.Add(new Point() { X = Snake[Snake.Count - 1].X + snake.Width, Y = Snake[Snake.Count - 1].Y });
        }
    }
}
