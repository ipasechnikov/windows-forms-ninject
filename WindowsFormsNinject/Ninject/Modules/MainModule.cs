using Ninject.Modules;
using WindowsFormsNinject.Models;
using WindowsFormsNinject.Ninject.Providers;
using WindowsFormsNinject.ViewModels.MyUserControl;

namespace WindowsFormsNinject.Ninject.Modules
{
    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITestModel>().ToProvider<TestModelProvider>();
            Bind<IMyUserControlViewModel>().To<MyUserControlViewModel>();
        }
    }
}
