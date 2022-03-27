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
                BindViewModel(_viewModel);
            }
        }

        public void BindViewModel(IMyUserControlViewModel viewModel)
        {
            label1.DataBindings.Add(new Binding("Text", _viewModel, "LabelText"));
            textBox1.DataBindings.Add(new Binding("Text", _viewModel, "TextBoxText", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
