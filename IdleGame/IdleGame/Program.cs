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
            GameLoop.Start();

            //These are for starting up winforms
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}