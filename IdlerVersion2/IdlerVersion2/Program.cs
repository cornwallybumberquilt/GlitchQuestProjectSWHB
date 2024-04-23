//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2
{
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
            Blip blip = new Blip(5, 1);
            World world = new World(100, 10, 10, blip);
            //world.PopulateWorld();
            //Form 1 is the form for project milestone 1
            //Application.Run(new Form1());
            //Worldview is the severely deformed form where I'm just trying to get the grid to update
            Application.Run(new NavigationMenuForm());
            Application.Run(new WorldView(world));
            //Application.Run(new WorldForm(world));

        }
    }
}