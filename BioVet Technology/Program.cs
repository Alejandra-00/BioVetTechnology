namespace BioVet_Technology
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormInicio());

            // Cuando termine el Run principal, liquida absolutamente todo en memoria
            Environment.Exit(0);
        }
    }
}