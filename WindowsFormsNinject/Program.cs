using Ninject;
using Ninject.Activation.Strategies;
using System;
using System.Windows.Forms;
using WindowsFormsNinject.Ninject.Modules;
using WindowsFormsNinject.Ninject.Strategies;
using WindowsFormsNinject.Views;

namespace WindowsFormsNinject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a Ninject kernel
            var kernel = new StandardKernel(new MainModule());

            // Great thanks to this answer on StackOverflow
            // https://stackoverflow.com/a/33928388
            kernel.Components.Add<IActivationStrategy, WindowsFormsStrategy>();

            // Inject depenecies and run application
            var mainForm = kernel.Get<MainForm>();
            Application.Run(mainForm);
        }
    }
}
