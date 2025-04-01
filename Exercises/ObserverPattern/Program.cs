namespace ObserverPattern
{
    // This implementation demonstrates the Observer Pattern using an interface and a Subject class. 
    // In real-world applications, especially in C#, it is more common to use events (`event` keyword), 
    // `Action<T>`, or engine-specific solutions like Unity's `UnityEvent` for handling observer patterns dynamically.
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject playerAttacked = new Subject();
            Enemy enemy = new Enemy();
            PlayerAttack playerAttack = new PlayerAttack(enemy);
            WinCondition winCondition = new WinCondition();

            playerAttacked.Attach(playerAttack);
            enemy.Died.Attach(winCondition);

            Console.WriteLine("Press 'E' to attack.\n");

            while (true)
            {
                string line = Console.ReadKey(true).KeyChar.ToString();
                if (line == "E" || line == "e")
                {
                    playerAttacked.Invoke(35);
                }
            }
        }
    }
}
