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
            Snake[0] = new Point() { X = Snake[0].X, Y = Snake[0].Y - 10 };
        }
        public void Down()
        {
            Snake[0] = new Point() { X = Snake[0].X, Y = Snake[0].Y + 10 };
        }
        public void Left()
        {
            Snake[0] = new Point() { X = Snake[0].X - 10, Y = Snake[0].Y  };
        }
        public void Right()
        {
            Snake[0] = new Point() { X = Snake[0].X + 10, Y = Snake[0].Y };
        }
    }
}
