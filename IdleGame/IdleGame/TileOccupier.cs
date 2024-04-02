namespace IdleGame
{
    internal class TileOccupier : Panel
    {
        public int _size;
        public int _x, _y;
        public Color _color;

        public TileOccupier(int size, int x, int y)
        {
            this._size = size;
            this._x = x;
            this._y = y;
            this.BackColor = RandomColor();
        }
        public void Draw(int x, int y)
        {
            //This can be used to draw the panel to the screen once you make it visible
            this.Location = new Point(x, y);
        }
        public Color RandomColor()
        {
            Random r = new Random();

            r.Next(0, 2);
            if (r.Next(0, 5) == 0)
            {
                return Color.Blue;
            }

            return Color.Green;
        }
    }
}
