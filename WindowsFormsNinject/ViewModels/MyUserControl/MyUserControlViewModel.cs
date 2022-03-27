using WindowsFormsNinject.Models;

namespace WindowsFormsNinject.ViewModels.MyUserControl
{
    public class MyUserControlViewModel : BaseViewModel, IMyUserControlViewModel
    {
        private ITestModel _model;

        private string _labelText;

        public MyUserControlViewModel(ITestModel model)
        {
            _model = model;
            LabelText = model.TestText;
        }

        public string TextBoxText
        {
            get { return _model.TestText; }
            set
            {
                _model.TestText = value;
                LabelText = value;
                NotifyPropertyChanged("TextBoxText");
            }
        }

        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value.ToUpper();
                NotifyPropertyChanged("LabelText");
            }
        }
    }
}
