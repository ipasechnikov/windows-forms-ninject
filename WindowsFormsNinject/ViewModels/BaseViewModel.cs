using System.ComponentModel;

namespace WindowsFormsNinject.ViewModels
{
    public abstract class BaseViewModel : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Set<T>(object model, string propertyName, T value)
        {
            model.GetType().GetProperty(propertyName).SetValue(model, value, null);
            NotifyPropertyChanged(propertyName);
        }
    }
}
