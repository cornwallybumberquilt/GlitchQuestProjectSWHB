using Glitchquest.Enemies;
using Glitchquest.Environments;

namespace Glitchquest
{
    /// <summary>
    /// creates an object meant to display a cell on a grid
    /// </summary>
    public class SquareView : Panel
    {

        public Square _square;
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="square"></param>
        public SquareView(Square square)
        {
            _square = square;

        }
        /// <summary>
        /// Draws a cell to the screen using it's x/y coordinates and size of the cells
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="xSize"></param>
        /// <param name="ySize"></param>
        public void Draw(int x, int y, int xSize, int ySize)
        {
            _square._x = x;
            _square._y = y;
            Size = new Size(xSize, ySize);
            Location = new Point(xSize * x, ySize * y);

            Visible = true;
            if (_square._beingRavaged == true && _square._ravaged == true)
            {
                BackgroundImage = Properties.Resources.GridSquareHead;
            }
            else if (_square._beingRavaged == true)
            {
                BackgroundImage = Properties.Resources.GridSquareHead;
            }
            else if (_square._ravaged == true)
            {
                Random r = new Random();
                int random = r.Next(5);
                if (random == 0)
                {
                    BackgroundImage = Properties.Resources.Glitch1;
                }
                else if (random == 1)
                {
                    BackgroundImage = Properties.Resources.Glitch2;
                }
                else if (random == 2)
                {
                    BackgroundImage = Properties.Resources.Glitch3;
                }
                else if (random == 3)
                {
                    BackgroundImage = Properties.Resources.glitch4;
                }
                else { BackgroundImage = Properties.Resources.Ravaged; }
            }
            ///Chosen if Blip is in the square
            else if (_square._occupied == true)
            {
                BackgroundImage = Properties.Resources.blip;
            }
            ///Chosen if a tile that was filled prior has been emptied
            else if (_square._removeSquareEvent == true)
            {
                BackgroundImage = Properties.Resources.Grid_Tile;
            }

            ///Following chosen by various square types
            else if (_square.Name is "Mountian")
            {
                BackgroundImage = Properties.Resources.rocky_crag;
            }
            else if (_square.Name is "Tree")
            {
                BackgroundImage = Properties.Resources.forest;
            }
            else if (_square.Name is "Desert")
            {
                BackgroundImage = Properties.Resources.safe_clearing;
            }
            else if (_square.Name is "Chest")
            {
                BackgroundImage = Properties.Resources.loot_chest_2;
            }
            else if (_square.Name is "Hungry")
            {
                BackgroundImage = Properties.Resources.hungry;
            }
            else if (_square.Name is "LostSouls")
            {
                BackgroundImage = Properties.Resources.lost_souls1;
            }
            else if (_square.Name is "AngryCircle")
            {
                BackgroundImage = Properties.Resources.GridAngryCircle;
            }
            else if (_square.Name is "Mimic")
            {
                if(_square._mimic == true) 
                {
                    BackgroundImage = Properties.Resources.loot_chest_2;
                }
                BackgroundImage = Properties.Resources.loot_chest_2;
            }
            else if (_square.Name is "CursedSword")
            {
                BackgroundImage = Properties.Resources.red_old_sword;
            }
            else if (_square.Name is "StrangeHorse")
            {
                BackgroundImage = Properties.Resources.GridStrangeHorse;
            }
            ///Chosen if not filled by any other square condition
            else
            {
                BackgroundImage = Properties.Resources.Grid_Tile;
            }
            BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
