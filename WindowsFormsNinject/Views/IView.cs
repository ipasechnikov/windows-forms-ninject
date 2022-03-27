using WindowsFormsNinject.ViewModels;

namespace WindowsFormsNinject.Views
{
    public interface IView<TViewModel> where TViewModel : IViewModel
    {
        /// <summary>
        /// For WinForms designer to work correctly it's required to use only default contructor
        /// But having only a default constructor means that we cannot use constructor depenndecy injection
        /// That's why we are using property dependecy injection
        /// </summary>
        TViewModel ViewModel { get; set; }

        /// <summary>
        /// Bind controls to ViewModel fields in this method
        /// Then call this method in ViewModel setter
        /// </summary>
        /// <param name="viewModel">Viewmodel used for binding</param>
        void BindViewModel(TViewModel viewModel);
    }
}
