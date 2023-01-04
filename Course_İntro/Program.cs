using Course_İntro.Helpers;

namespace Course_İntro
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
            Application.Run(new LoginView());

            
            //string name = "can";
            //string upperName = StringHelpers.MakeAllUpperCase(name);
            //MessageBox.Show(upperName);
        }
    }
}