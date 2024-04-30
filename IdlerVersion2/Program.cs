//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest
{
    /// <summary>
    /// Glitchquest Idler
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Blip blip = new Blip();
            World world = new World(100, 10, 10, blip);
            //Worldview is the main form of the program
            Application.Run(new WorldView(world));

        }
    }
}