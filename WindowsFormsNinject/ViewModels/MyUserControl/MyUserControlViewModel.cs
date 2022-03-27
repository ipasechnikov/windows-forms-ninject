using WindowsFormsNinject.Models;

namespace WindowsFormsNinject.ViewModels.MyUserControl
{
    /// <summary>
    /// Concrete implementation of IMyUserControlViewModel interface
    /// This implementation saves textbox text as it is into model
    /// And displays uppercased textbox text in label
    /// </summary>
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

                // Notify view that property has changed
                NotifyPropertyChanged("TextBoxText");
            }
        }

        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value.ToUpper();

                // Notify view that property has changed
                NotifyPropertyChanged("LabelText");
            }
        }
    }
}
