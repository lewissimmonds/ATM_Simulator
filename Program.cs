using System.Windows.Forms;

namespace ATM_Simulator
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

            // Create two threads, each running its own instance of the application
            Thread Atm0 = new Thread(() => Application.Run(new ATM()));
            Thread Atm1 = new Thread(() => Application.Run(new ATM()));
            Thread CenComp = new Thread(() => Application.Run(new ATM())); // REPLACE WITH CENTRAL COMPUTER APP!!!!!!!

            // Start the threads
            Atm0.Start();
            Atm1.Start();
            CenComp.Start();

            
        }
    }
}

// bing chilling