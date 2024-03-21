using IdleGame;

namespace IdleGame
{
    /// <summary>
    /// This is for the main gameloop to play the game
    /// </summary>
    internal class GameLoop
    {
        /// <summary>
        /// Starts the game loop
        /// </summary>
        public static void Start()
        {
            int dt = 0; //Variable for delta time
            int fps = 240; //Variable for game fps

            //Instantiates a new world for blobperson to explore
            World world = new World(20, 20, 20);

            //PyGame stuff
        }
    }
}
