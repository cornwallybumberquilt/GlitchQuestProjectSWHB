namespace IdleGame
{
    /// <summary>
    /// Class for creating an object for the main character/blob thing
    /// </summary>
    internal class Blip : TileOccupier
    {
        int actionCooldown;
        int currentActionCooldown;
        public List<(int, int)> validMoves;
        Color color;

        /// <summary>
        /// Parameterized constructor for blobperson
        /// </summary>
        /// <param name="size"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="actionCooldownSeconds"></param>
        /// <param name="color"></param>
        public Blip(int size, int x, int y, int actionCooldownSeconds) : base(size, x, y)
        {
            this.actionCooldown = actionCooldownSeconds;
            this.currentActionCooldown = actionCooldown;
            this.validMoves = new List<(int, int)>();
            this.BackColor = Color.Black;
        }

        /// <summary>
        /// Used to move blobperson when the cooldown reaches 0
        /// </summary>
        /// <param name="dt"></param>
        public void Update(int dt)
        {
            currentActionCooldown -= dt;
            if (currentActionCooldown <= 0)
            {
                Move();
                currentActionCooldown = actionCooldown;
            }
        }
        /// <summary>
        /// This will be used to add blobperson to the screen in winforms
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Draw(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        /// <summary>
        /// This moves blobperson to a random square based off of their valid list of moves
        /// </summary>
        public void Move()
        {
            Random r = new Random();
            var movesList = validMoves.ToList();
            (int, int) randomMove = movesList[r.Next(movesList.Count)];
            _x = randomMove.Item1;
            _y = randomMove.Item2;
        }
        /// <summary>
        /// This finds the list of cells near blobperson, it will have to be updated to add corners into the valid moves
        /// </summary>
        /// <returns></returns>
        public List<(int, int)> GetAdjacentCells()
        {
            List<(int, int)> adjacentCells = new List<(int, int)>();
            adjacentCells.Add((_x + _size, _y));
            adjacentCells.Add((_x - _size, _y));
            adjacentCells.Add((_x, _y + _size));
            adjacentCells.Add((_x, _y - _size));
            return adjacentCells;
        }
    }
}
