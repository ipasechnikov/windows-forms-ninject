using Ninject.Activation;
using WindowsFormsNinject.Models;

namespace WindowsFormsNinject.Ninject.Providers
{
    /// <summary>
    /// Provider used by Ninject to inject ITestModel
    /// </summary>
    public class TestModelProvider : Provider<ITestModel>
    {
        protected override ITestModel CreateInstance(IContext context)
        {
            return new TestModel("Created by custom Ninject Provider");
        }
    }
}
