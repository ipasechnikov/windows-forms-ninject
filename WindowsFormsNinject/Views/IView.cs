using WindowsFormsNinject.ViewModels;

namespace WindowsFormsNinject.Views
{
    /// <summary>
    /// Every form or control must inherit from this interface if they use MVVM pattern
    /// </summary>
    /// <typeparam name="TViewModel">viewmodel interface</typeparam>
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
