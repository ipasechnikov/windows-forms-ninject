using Ninject.Activation;
using WindowsFormsNinject.Models;

namespace WindowsFormsNinject.Ninject.Providers
{
    public class TestModelProvider : Provider<ITestModel>
    {
        protected override ITestModel CreateInstance(IContext context)
        {
            return new TestModel("Created by Ninject Provider");
        }
    }
}
