//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
using Glitchquest.Enemies;
using Glitchquest.Environments;

namespace Glitchquest
{
    /// <summary>
    /// Creates an instance of a world object
    /// </summary>
    public class World
    {
        public Grid _grid;
        public int _cellSize;
        public int _numRows;
        public int _numCols;
        public Blip _blip;
        public SquareHead _squareHead;
        public int _turnCount;
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="cellSize"></param>
        /// <param name="numRows"></param>
        /// <param name="numCols"></param>
        /// <param name="blip"></param>
        public World(int cellSize, int numRows, int numCols, Blip blip)
        {
            _blip = blip;
            _cellSize = cellSize;
            _numRows = numRows;
            _numCols = numCols;
            _grid = new Grid(cellSize, numRows, numCols);
            _blip._x = numRows / 2;
            _blip._y = numCols / 2;
            _turnCount = 0;
            CreateLayout();
            PopulateWorld();
        }



        /// <summary>
        /// Creates a shuffled grid layout using rows and collumns
        /// </summary>
        public void CreateLayout()
        {
            int cells = _numRows * _numCols;
            int cellsPercent = cells / 100;
            int mountainsPercent = cellsPercent * 20;
            int treesPercent = cellsPercent * 5;
            int desertPercent = cellsPercent * 5;
            int enemyPercent = cellsPercent * 10;
            _turnCount = 0;
            _squareHead = new SquareHead();
            for (int i = 0; i < mountainsPercent; i++)
            {
                _grid._squares.Add(new Mountain());
            }

            for (int i = 0; i < treesPercent; i++)
            {
                _grid._squares.Add(new Tree());
            }

            for (int i = 0; i < desertPercent; i++)
            {
                _grid._squares.Add(new Desert());
            }

            for (int i = 0; i < enemyPercent; i++)
            {
                Random r = new Random();
                int randomNumber = r.Next(6);
                if (randomNumber == 0)
                {
                    _grid._squares.Add(new MadGuy());
                }
                else if (randomNumber == 1)
                {
                    _grid._squares.Add(new Snake());
                }
                else if (randomNumber == 2)
                {
                    _grid._squares.Add(new AngryCircle());
                }
                else if (randomNumber == 3)
                {
                    _grid._squares.Add(new RandomScribbles());
                }
                else if (randomNumber == 4)
                {
                    _grid._squares.Add(new BadGrade());
                }
                else if (randomNumber == 5)
                {
                    _grid._squares.Add(new StrangeHorse());
                }
            }

            while (_grid._squares.Count() < _numRows * _numCols)
            {
                _grid._squares.Add(new Square());
            }
            _grid._squares = _grid._squares.OrderBy(x => Random.Shared.Next()).ToList();
        }
        /// <summary>
        /// gives each square in the grid an x or y coordinate, and assigns an occupied true flag to the square where blip is currently located
        /// </summary>
        public void PopulateWorld()
        {
            int i = 0;
            for (int x = 0; x < _numRows; x++)
            {

                for (int y = 0; y < _numCols; y++)
                {

                    _grid._squares[i]._x = x;
                    _grid._squares[i]._y = y;
                    if (x == _blip._x && y == _blip._y) { _grid._squares[i]._occupied = true; }
                    i++;
                }
            }
        }
        /// <summary>
        /// makes blip move arround the grid
        /// </summary>
        public void AdvanceWorld()
        {
            if (_blip.health == 0)
            {
                _blip.fear = 0;
                _blip.deathCounter += 1;
                _blip.health = _blip.maxHealth;
                _blip.tired = _blip.maxTired;
                _blip.hunger = _blip.maxHunger;
                _blip._x = _numRows / 2;
                _blip._y = _numCols / 2;
                _blip.inventory = new Inventory.Inventory();
                _blip.RecentActions = new List<string>();
                _blip.RecentActions.Add($"{_blip.Name} can't help but feel that something awful happened to them.");
                _grid = new Grid(_cellSize, _numRows, _numCols);
                CreateLayout();
                PopulateWorld();
            }



            else
            {
                if (_turnCount == 100)
                {
                    _blip.RecentActions.Add($"{_blip.Name} feels a chill down their spine...");
                    _squareHead.awake = true;
                    _squareHead._x = 0;
                    _squareHead._y = -1;
                    _blip.fear = 1;
                }
                bool foundBlip = false;
                if (_squareHead.awake == true)
                {
                    _squareHead.GetAdjacentCells(_grid._squares);
                    _squareHead.Update();
                }
                _blip.GetAdjacentCells(_grid._squares);

                bool performedAction = _blip.Update();


                int i = 0;
                if (performedAction || _squareHead.awake)
                {
                    for (int j = 0; j < _grid._rows; j++)
                    {
                        for (int k = 0; k < _grid._columns; k++)
                        {
                            _grid._squares[i]._wasOccupied = false;
                            if (_grid._squares[i]._occupied == true)
                            {
                                _grid._squares[i]._wasOccupied = true;
                                _grid._squares[i]._occupied = false;
                            }
                            if (_grid._squares[i]._beingRavaged == true)
                            {
                                _grid._squares[i]._ravaged = true;
                                _grid._squares[i]._beingRavaged = false;
                            }
                            if ((_grid._squares[i]._x == _blip._x && _grid._squares[i]._y == _blip._y)
                            && (_grid._squares[i]._x == _squareHead._x && _grid._squares[i]._y == _squareHead._y))
                            {
                                if (_blip.attack > _squareHead.defense && _blip.defense > _squareHead.attack)
                                {
                                    _blip.RecentActions.Add($"{_blip.Name} finally defeated the plague, SquareHead.");
                                }
                                else
                                {
                                    _blip.RecentActions.Add($"{_blip.Name} was ravaged.");
                                    _blip.TakeDamage(_blip.maxHealth);
                                }
                            }
                            if ((_grid._squares[i]._x == _blip._x && _grid._squares[i]._y == _blip._y) && foundBlip == false)
                            {
                                _grid._squares[i]._occupied = true;
                                _grid._squares[i].OccupiedEvent(_blip);
                                foundBlip = true;

                            }
                            if ((_grid._squares[i]._x == _squareHead._x && _grid._squares[i]._y == _squareHead._y))
                            {
                                _grid._squares[i]._beingRavaged = true;
                            }
                            i++;
                        }
                    }
                }
                _turnCount++;
            }
        }
    }
}
