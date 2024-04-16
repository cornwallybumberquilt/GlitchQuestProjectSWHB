namespace IdlerVersion2
{
    /// <summary>
    /// creates an object meant to display a cell on a grid
    /// </summary>
    internal class SquareView : Panel
    {
        Square _square;
        public SquareView(Square square)
        {
            _square = square;

        }

        public void Draw(int x, int y, int xSize, int ySize)
        {
            _square._x = x;
            _square._y = y;
            Size = new Size(xSize, ySize);
            Location = new Point(xSize * x, ySize * y);

            Visible = true;
            if (_square.Name == "Blip" || _square._occupied == true)
            {
                BackgroundImage = Properties.Resources.GridSirBlip;
            }
            else
            {
                BackgroundImage = Properties.Resources.Grid_Tile;
            }
            BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
