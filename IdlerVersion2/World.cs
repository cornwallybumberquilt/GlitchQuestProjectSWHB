//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
using Glitchquest.Enemies;
using Glitchquest.Environments;
using Newtonsoft.Json;

namespace Glitchquest
{
    /// <summary>
    /// Creates an instance of a world object
    /// </summary>
    [Serializable]
    public class World
    {
        [JsonProperty]
        public Grid _grid;

        [JsonProperty]
        public int _cellSize;

        [JsonProperty]
        public int _numRows;

        [JsonProperty]
        public int _numCols;

        [JsonProperty]
        public Blip _blip;

        [JsonProperty]
        public SquareHead _squareHead;

        [JsonProperty]
        public int _turnCount;

        [JsonProperty]
        double currentCooldown = 0;

        [JsonProperty]
        double cooldown = 10;

        [JsonProperty]
        public double gameSpeedModifier;

        [JsonProperty]
        public int worldLevel;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="cellSize"></param>
        /// <param name="numRows"></param>
        /// <param name="numCols"></param>
        /// <param name="blip"></param>
        public World(int cellSize, int numRows, int numCols, Blip blip)
        {
            // instializing blip in this way ensures that an object is present when using the load feature
            _blip = blip ?? new Blip();
            _cellSize = cellSize;
            _numRows = numRows;
            _numCols = numCols;
            _grid = new Grid(cellSize, numRows, numCols);
            _blip._x = numRows / 2;
            _blip._y = numCols / 2;
            gameSpeedModifier = 1;
            _turnCount = 0;
            CreateLayout();
            PopulateWorld();
            worldLevel = 1;
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
            int chestPercent = cellsPercent * 1;
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
                int randomNumber = 0;

                randomNumber = r.Next(100);
                if (randomNumber >= 95) 
                { 
                randomNumber = 99;
                }

                else if (_blip.level == 1)
                {
                    randomNumber = r.Next(0, _blip.level + 2);
                }
                else if (_blip.level >= 4)
                {
                    randomNumber = r.Next(3, 5);
                }
                else
                {
                    randomNumber = r.Next(_blip.level - 1, _blip.level + 2);
                }

                if (randomNumber == 0)
                {
                    _grid._squares.Add(new LostSouls());
                }
                
                else if (randomNumber == 1)
                {
                    _grid._squares.Add(new Hungry());
                }
                else if (randomNumber == 2)
                {
                    _grid._squares.Add(new CursedSword());
                }
                else if (randomNumber == 3)
                {
                    _grid._squares.Add(new AngryCircle());
                }
                
                else if (randomNumber == 4)
                {
                    _grid._squares.Add(new StrangeHorse());
                }
                else if (randomNumber == 99)
                {
                    _grid._squares.Add(new Mimic());
                }
            }

            for (int i = 0; i < chestPercent; i++)
            {
                _grid._squares.Add(new Chest());
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
            double activeCooldown = currentCooldown * gameSpeedModifier;
            if(activeCooldown >= cooldown) {
                currentCooldown = 0;
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
                                if ((_grid._squares[i] is Chest || _grid._squares[i] is Mimic) && _turnCount > 10) 
                                {
                                    _grid._squares[i]._removeSquareEvent = true;
                                }
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
                                        worldLevel += 1;
                                        _squareHead.awake = false;
                                        _blip = new Blip();
                                        CreateLayout();
                                        PopulateWorld();
                                        _blip.RecentActions.Add($"{_blip.Name} finally defeated the plague, SquareHead.");
                                        break;
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
            currentCooldown += 1;
        }

        public void Save(string filePath)
        {
            string json = JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(filePath, json);
        }

        public static World Load(string filePath)
        {
            string json = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<World>(json);
        }

    }
}
