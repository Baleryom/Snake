namespace Snake
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SnakeController controller = new SnakeController();
            controller.StartGame();
        }
    }
}