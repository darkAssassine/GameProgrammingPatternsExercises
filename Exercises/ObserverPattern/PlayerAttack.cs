namespace ObserverPattern
{
    internal class PlayerAttack : IObserver
    {
        Enemy enemy;
        public PlayerAttack(Enemy _enemy)
        {
            enemy = _enemy;
        }
        public void Notify(int damage)
        {
            enemy.TakeDamage(damage);
        }
    }
}
