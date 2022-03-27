using Ninject;
using WindowsFormsNinject.ViewModels;

namespace WindowsFormsNinject.Views
{
    internal interface IView<TViewModel> where TViewModel : IViewModel
    {
        [Inject]
        TViewModel ViewModel { get; set; }
        void BindViewModel(TViewModel viewModel);
    }
}
