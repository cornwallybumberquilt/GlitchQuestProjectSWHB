namespace Glitchquest
{
    /// <summary>
    /// Creates an instance for main antagonist of the game
    /// </summary>
    public class SquareHead : Square
    {
        int actionCooldown;
        int currentActionCooldown;
        public int defense;
        public int attack;
        public List<(int, int)> validMoves;
        public bool awake;

        /// <summary>
        /// Default constructor
        /// </summary>
        public SquareHead()
        {
            Name = "SquareHead";
            _x = -1;
            _y = -1;
            actionCooldown = 2;
            currentActionCooldown = 0;
            defense = 98;
            attack = 98;
            validMoves = new List<(int, int)>();
            awake = false;
        }
        /// <summary>
        /// Updates Squarehead's movement if his cooldown
        /// </summary>
        public void Update()
        {
            if (currentActionCooldown >= actionCooldown)
            {
                Move();
                currentActionCooldown = 0;
            }
            currentActionCooldown +=1;
        }
        /// <summary>
        /// Moves Squarehead based off his valid move options
        /// </summary>
        public void Move()
        {
            Random r = new Random();
            int moveChoice = (validMoves.Count());
            moveChoice = r.Next(moveChoice);

            _x = validMoves[moveChoice].Item1;
            _y = validMoves[moveChoice].Item2;
        }
        /// <summary>
        /// Gets a list of valid moves for Squarehead
        /// </summary>
        /// <param name="squares"></param>
        public void GetAdjacentCells(List<Square> squares)
        {

            List<(int, int)> adjacentCells = new List<(int, int)>();

            for (int j = 0; j < squares.Count; j++)
            {

                if ((squares[j]._x >= this._x - 1 && squares[j]._x <= this._x + 1) && (squares[j]._y >= this._y - 1 && squares[j]._y <= this._y + 1))
                {
                    if (adjacentCells.Contains((squares[j]._x, squares[j]._y)) || (squares[j]._x, squares[j]._y) == (_x, _y) || squares[j]._ravaged == true)
                    {
                        continue;
                    }


                    adjacentCells.Add((squares[j]._x, squares[j]._y));
                }
            }


            if (adjacentCells.Count() == 0)
            {

                for (int j = 0; j < squares.Count; j++)
                {

                    if ((squares[j]._x >= this._x - 1 && squares[j]._x <= this._x + 1) && (squares[j]._y >= this._y - 1 && squares[j]._y <= this._y + 1))
                    {
                        if (adjacentCells.Contains((squares[j]._x, squares[j]._y)) || (squares[j]._x, squares[j]._y) == (_x, _y)) { continue; }
                        adjacentCells.Add((squares[j]._x, squares[j]._y));
                    }
                }

            }
            validMoves = adjacentCells;
        }
    }
}
