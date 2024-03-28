namespace IdleGame
{
    /// <summary>
    /// Class for creating a world object
    /// </summary>
    internal class World
    {
        Grid grid;
        Blip blip;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="cellSize"></param>
        /// <param name="numRows"></param>
        /// <param name="numCols"></param>
        public World(int cellSize, int numRows, int numCols)
        {
            this.grid = new Grid(cellSize, numRows, numCols);
            blip = new Blip(cellSize, (numCols / 2 * cellSize), (numRows / 2 * cellSize), 1, 1);
        }
        /// <summary>
        /// Updates blip and grid to be ready for the next action
        /// </summary>
        /// <param name="dt"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Update(int dt)
        {
            blip.validMoves = grid.cells.Intersect(blip.GetAdjacentCells()).ToList();

            blip.Update(dt);
            grid.Update(dt);

        }
        /// <summary>
        /// Will draw both the grid and blip to the screen using winform
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
