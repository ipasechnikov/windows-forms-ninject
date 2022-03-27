using Ninject.Modules;
using WindowsFormsNinject.Models;
using WindowsFormsNinject.Ninject.Providers;
using WindowsFormsNinject.ViewModels.MyUserControl;

namespace WindowsFormsNinject.Ninject.Modules
{
    /// <summary>
    /// Ninject module to configure dependency injections
    /// </summary>
    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            // Use custom provider to inject into ITestModel
            Bind<ITestModel>().ToProvider<TestModelProvider>();

            // Use a concrete implementation of IMyUserControlViewModel interface
            Bind<IMyUserControlViewModel>().To<MyUserControlViewModel>();
        }
    }
}
