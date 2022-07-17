namespace Snake
{
    class SnakeController
    {
        private Game game;
        private Graphics g;
        private SnakeFrm snakeView;
        private SolidBrush brush = new SolidBrush(Color.Black);
        private SolidBrush green = new SolidBrush(Color.Green);
        private SolidBrush red = new SolidBrush(Color.Red);
        private Rectangle sidebar = new Rectangle(0, 0, 800, 800);
        private int lastInput = 0;
        private int score = 0;
        private bool isEaten = true;
        Rectangle snakePart, applePart;

        public SnakeController()
        {
            this.snakeView = new SnakeFrm();
            this.snakeView.KeyDown += new KeyEventHandler(Snake_Form_KeyDown);
            this.snakeView.Paint += new PaintEventHandler(Snake_Form_Draw);
            this.snakeView.t.Tick += new System.EventHandler(Snake_Form_Tick);
        }

        public void StartGame()
        {
            this.game = new Game();
            this.snakeView.ShowDialog();
        }

        private void Snake_Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    game.Up();
                    lastInput = 0;
                    break;
                case Keys.Down:
                    game.Down();
                    lastInput = 1;
                    break;
                case Keys.Left:
                    game.Left();
                    lastInput = 2;
                    break;
                case Keys.Right:
                    game.Right();
                    lastInput = 3;
                    break;
            }
        }

        private void Snake_Form_Draw(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            e.Graphics.FillRectangle(brush, sidebar);
            DrawSnake(g, e, game.Snake);
            DrawApple(g, e);
            isEaten = game.CheckCollision(applePart, snakePart);
            e.Graphics.DrawString($"SCORE:{score}", new Font("Times New Roman", 25.0f), brush, new PointF(350f, 30f));
        }

        private void Snake_Form_Tick(object sender, System.EventArgs e)
        {
            snakeView.Refresh();
            switch (lastInput)
            {
                case 0:
                    game.Up();
                    break;
                case 1:
                    game.Down();
                    break;
                case 2:
                    game.Left();
                    break;
                case 3:
                    game.Right();
                    break;
            }
            snakeView.Refresh();
        }

        private void DrawSnake(Graphics g, PaintEventArgs e, List<Point> snake)
        {
            snakePart = new Rectangle(snake[0].X, snake[0].Y, 20, 20);
            g.FillRectangle(green, snakePart);
        }

        private void DrawApple(Graphics g, PaintEventArgs e)
        {
            if(isEaten){
                applePart = new Rectangle(new Random().Next(1, 7)*100, new Random().Next(1, 3)*100, 20, 20);
            }            
            g.FillRectangle(red, applePart);
        }
    }
}
