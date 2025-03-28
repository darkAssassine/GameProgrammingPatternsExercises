namespace CommandPattern
{
    internal class Command
    {
        public Command() { }
        public virtual void Execute() { }
        public virtual void Undo() { }
    }
}
