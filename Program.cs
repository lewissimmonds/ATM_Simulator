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

            Bank bank = new Bank();


            Thread Atm0 = new Thread(() => Application.Run(new ATM(bank)));
            Thread Atm1 = new Thread(() => Application.Run(new ATM(bank)));
            Thread CenComp = new Thread(() => Application.Run(new CentralBankForm(bank))); // REPLACE WITH CENTRAL COMPUTER APP!!!!!!!

            // Start the threads
            Atm0.Start();
            //Atm1.Start();
            //CenComp.Start();

            
        }
    }
}

// bing chilling