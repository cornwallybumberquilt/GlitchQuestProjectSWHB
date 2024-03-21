namespace IdleGame
{
    /// <summary>
    /// Class for creating a grid object
    /// </summary>
    internal class Grid
    {
        int cellSize { get; set; }
        int numRows { get; set; }
        int numCols { get; set; }
        double height;
        double width;
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
            this.height = this.numRows * this.cellSize;
            this.width = this.numCols * this.cellSize;
            this.renderLines = renderLines;
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
        public void Draw()
        {
            throw new NotImplementedException();
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
