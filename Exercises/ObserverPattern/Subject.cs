namespace ObserverPattern
{
    internal class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver _observer)
        {
            observers.Add(_observer);
        }

        public void Detach(IObserver _observer)
        {
            observers.Remove(_observer);
        }

        public void Invoke(int _damage)
        {
            foreach (IObserver _observer in observers)
            {
                _observer.Notify(_damage);
            }
        }
    }
}
