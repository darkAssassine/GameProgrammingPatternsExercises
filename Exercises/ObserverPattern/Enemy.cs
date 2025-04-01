namespace ObserverPattern
{
    internal class Enemy
    {
        int health = 100;
        public Subject Died = new Subject();

        public void TakeDamage(int _damage)
        {
            health -= _damage;
            Console.WriteLine($"Enemy has {health} left.");
            if (health <= 0)
            {
                Died.Invoke(0);
            }
        }
    }
}
