namespace IdleGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            static void GameLoop()
            {
                int dt = 0; //Variable for delta time
                int fps = 240; //Variable for game fps

                //Instantiates a new world for blobperson to explore
                World world = new World(20, 20, 20);

                //PyGame stuff
            }

            //These are for starting up winforms
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}