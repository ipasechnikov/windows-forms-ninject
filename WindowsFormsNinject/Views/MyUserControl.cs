using Ninject;
using System.Windows.Forms;
using WindowsFormsNinject.ViewModels.MyUserControl;

namespace WindowsFormsNinject.Views
{
    public partial class MyUserControl : UserControl, IView<IMyUserControlViewModel>
    {
        private IMyUserControlViewModel _viewModel;

        public MyUserControl()
        {
            InitializeComponent();
        }

        [Inject]
        public IMyUserControlViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;

                // Bind textbox and label fields after viewmodel is injected
                BindViewModel(_viewModel);
            }
        }

        public void BindViewModel(IMyUserControlViewModel viewModel)
        {
            // Bind label's Text property to viewmodel's LabelText property
            label1.DataBindings.Add(new Binding("Text", _viewModel, "LabelText"));

            // Bind textbox's Text property to viewmodel's TextBoxText property
            // You have to pass DataSourceUpdateMode.OnPropertyChanged otherwise viewmodel property won't be updated
            textBox1.DataBindings.Add(new Binding("Text", _viewModel, "TextBoxText", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
