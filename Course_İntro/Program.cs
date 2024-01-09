using Course_İntro.Abstracts;
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


            //solution 1
            //IAuth loginView = new LoginView();
            //Application.Run(loginView as LoginView);

            //if (loginView.IsAuth)
            //{
            //    Application.Run(new MainView());
            //}


            //solution 2

           // Application.Run(new LoginView());
            Application.Run(new MainView());


            //string name = "can";
            //string upperName = StringHelpers.MakeAllUpperCase(name);
            //MessageBox.Show(upperName);
        }
    }
}