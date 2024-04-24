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
                BackgroundImage = Properties.Resources.GridSirBlip;
            }
            ///Chosen if a tile that was filled prior has been emptied
            else if (_square._removeSquareEvent == true)
            {
                BackgroundImage = Properties.Resources.Grid_Tile;
            }

            ///Following chosen by various square types
            else if (_square is Mountain)
            {
                BackgroundImage = Properties.Resources.GridMountain;
            }
            else if (_square is Tree)
            {
                BackgroundImage = Properties.Resources.GridTree;
            }
            else if (_square is Desert)
            {
                BackgroundImage = Properties.Resources.GridDesert;
            }
            else if (_square is MadGuy)
            {
                BackgroundImage = Properties.Resources.GridMadGuy;
            }
            else if (_square is Snake)
            {
                BackgroundImage = Properties.Resources.GridSnake;
            }
            else if (_square is AngryCircle)
            {
                BackgroundImage = Properties.Resources.GridAngryCircle;
            }
            else if (_square is BadGrade)
            {
                BackgroundImage = Properties.Resources.GridBadGrade;
            }
            else if (_square is RandomScribbles)
            {
                BackgroundImage = Properties.Resources.GridRandomScribbles;
            }
            else if (_square is StrangeHorse)
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
