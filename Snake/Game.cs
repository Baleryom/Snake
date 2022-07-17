using System.Diagnostics;

namespace Snake
{
    class Game
    {
        public List<Point> Snake = new List<Point>();
        public Stack<Point> SnakeBody = new Stack<Point>();
        
        public Game()
        {
            Snake.Add(new Point() { X = 200, Y = 200 });
        }
        public void Up()
        {
            if (Snake[0].Y - 10 < 0)
            {
                Snake[0] = new Point() { X = Snake[0].X, Y = 440 };
            }
            Snake[0] = new Point() { X = Snake[0].X, Y = Snake[0].Y - 10 };
            
        }
        public void Down()
        {
            if (Snake[0].Y + 10 > 440)
            {
                Snake[0] = new Point() { X = Snake[0].X, Y = 0 };
            }
            Snake[0] = new Point() { X = Snake[0].X, Y = Snake[0].Y + 10 };
        }
        public void Left()
        {
            if (Snake[0].X - 10 < 0)
            {
                Snake[0] = new Point() { X = 800, Y = Snake[0].Y };
            }
            Snake[0] = new Point() { X = Snake[0].X - 10, Y = Snake[0].Y };
        }
        public void Right()
        {
            if (Snake[0].X + 10 > 800)
            {
                Snake[0] = new Point() { X = 0, Y = Snake[0].Y };
            }
            Snake[0] = new Point() { X = Snake[0].X + 10, Y = Snake[0].Y };
        }

        public bool CheckCollision(Rectangle apple, Rectangle snake, ref int score)
        {
            Debug.Write(snake.X+" : "+ snake.Y+"\n");
            if (apple.X == snake.X && apple.Y == snake.Y)
            {
                score++;
                return true;
            }                
            else
                return false;
        }
    }
}
