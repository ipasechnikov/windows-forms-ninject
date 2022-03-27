using System.ComponentModel;

namespace WindowsFormsNinject.ViewModels
{
    public interface IViewModel : INotifyPropertyChanged
    {
        void NotifyPropertyChanged(string propertyName);
        void Set<T>(object model, string propertyName, T value);
    }
}
