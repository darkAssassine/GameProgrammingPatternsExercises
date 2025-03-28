namespace CommandPattern
{
    internal class MoveCommand : Command
    {
        Actor actor;
        int x, y;
        int xBefore, yBefore;

        public MoveCommand(Actor _actor, int _xDir, int _yDir)
        {
            Random rnd = new Random();
            actor = _actor;
            x = actor.x;
            y = actor.y;
            x += _xDir * rnd.Next(10);
            y += _yDir * rnd.Next(10);
            xBefore = x;
            yBefore = y;
        }

        public override void Execute()
        {
            actor.Move(x, y);
        }

        public override void Undo()
        {
            actor.Move(xBefore, yBefore);
        }
    }
}
