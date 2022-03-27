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

            var kernel = new StandardKernel(new MainModule());
            kernel.Components.Add<IActivationStrategy, WindowsFormsStrategy>();

            var mainForm = kernel.Get<MainForm>();
            Application.Run(mainForm);
        }
    }
}
