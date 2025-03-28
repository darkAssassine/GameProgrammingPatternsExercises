namespace CommandPattern
{
    internal class Actor
    {
        public int x, y;

        public void Move(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
