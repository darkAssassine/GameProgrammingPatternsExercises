namespace ObserverPattern
{
    internal class WinCondition : IObserver
    {
        public void Notify(int damage)
        {
            Console.WriteLine("You Win");
        }
    }
}
