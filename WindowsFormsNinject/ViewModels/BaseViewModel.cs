using System.ComponentModel;

namespace WindowsFormsNinject.ViewModels
{
    /// <summary>
    /// Concrete implementation of IViewModel interface
    /// </summary>
    public abstract class BaseViewModel : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
