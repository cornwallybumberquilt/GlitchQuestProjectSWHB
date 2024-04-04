//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2
{
    internal class Blip : Square
    {
        int actionCooldown;
        int currentActionCooldown;
        public List<(int, int)> validMoves;

        public Blip(int size, int actionCooldownSeconds) : base(size)
        {
            this.actionCooldown = actionCooldownSeconds;
            this.currentActionCooldown = actionCooldown;
            this.validMoves = new List<(int, int)>();
            this.BackColor = Color.Black;
        }

        public override (int, int) Update()
        {

            Random r = new Random();
            int randomChoice = validMoves.Count() + 1;
            randomChoice = r.Next(randomChoice);
            _x = validMoves[randomChoice].Item1;
            _y = validMoves[randomChoice].Item2;
            return validMoves[randomChoice];
        }

        public void GetAdjacentCells(List<Square> squares)
        {
            int movementModifier = 1;


            List<(int, int)> adjacentCells = new List<(int, int)>();

            for (int i = 0; i < squares.Count; i++)
            {
                for (int j = 0; j < squares.Count; j++)
                {
                    if ((squares[j]._x >= this._x - movementModifier && squares[j]._x <= this._x + movementModifier) && (squares[j]._y >= this._y - movementModifier && squares[j]._y <= this._y + movementModifier))
                    {
                        adjacentCells.Add((squares[j]._x, squares[j]._y));
                    }
                }
            }
            validMoves = adjacentCells;
        }
    }
}
