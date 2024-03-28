namespace IdleGame
{
    /// <summary>
    /// Class for creating a grid object
    /// </summary>
    internal class Grid : Panel
    {
        int cellSize { get; set; }
        int numRows { get; set; }
        int numCols { get; set; }
        bool renderLines { get; set; }
        public List<(int, int)> cells;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="cellSize"></param>
        /// <param name="numRows"></param>
        /// <param name="numCols"></param>
        /// <param name="renderLines"></param>
        public Grid(int cellSize, int numRows, int numCols, bool renderLines = false)
        {
            this.cellSize = cellSize;
            this.numRows = numRows;
            this.numCols = numCols;
            this.Height = this.numRows * this.cellSize;
            this.Width = this.numCols * this.cellSize;
            this.renderLines = renderLines;
            this.BackColor = Color.Black;
            this.cells = new List<(int, int)>();
            for (int x = 0; x < numRows; x++)
            {
                for (int y = 0; y < numCols; y++)
                {
                    this.cells.Add((x * cellSize, y * cellSize));
                }
            }
        }
        /// <summary>
        /// Left blank in starter code, likely used to update grid size
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Update(int dt)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// This will be used to draw the grid to the screen in winforms
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Draw(object sender, PaintEventArgs data)
        {
            Panel panel = sender as Panel;
            Graphics graphics = data.Graphics;

            // this sets the grid line color
            Pen pen = new Pen(Color.Yellow);

            // Draw horizontal lines
            for (int i = 0; i <= numRows; i++)
            {
                int y = i * cellSize;
                graphics.DrawLine(pen, 0, y, Width, y);
            }

            // Draw vertical lines
            for (int i = 0; i <= numCols; i++)
            {
                int x = i * cellSize;
                graphics.DrawLine(pen, x, 0, x, Height);
            }

            pen.Dispose();
        }
        /// <summary>
        /// This is a switch to toggle lines of the grid on and off
        /// </summary>
        public void ToggleLines()
        {
            this.renderLines = !this.renderLines;
        }
    }
}
