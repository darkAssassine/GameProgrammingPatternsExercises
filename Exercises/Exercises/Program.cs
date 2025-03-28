namespace CommandPattern
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            InputHandler inputHandler = new InputHandler();

            Console.WriteLine("WASD to move. Q to undo R to Redo. You move with random speed.");

            while (true)
            {
                inputHandler.Update();
            }
        }
    }
}
