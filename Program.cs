using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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

            //Create bank object
            Bank bank = new Bank();

            //Create central computer thread
            Thread CenComp = new Thread(() => Application.Run(new CentralBankForm(bank))); // REPLACE WITH CENTRAL COMPUTER APP!!!!!!!

            //Start the thread
            CenComp.Start();

            
        }
    }
}

// bing chilling