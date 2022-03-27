using System.ComponentModel;

namespace WindowsFormsNinject.Models
{
    public interface IModel : INotifyPropertyChanged
    {
        void NotifyPropertyChanged(string propertyName);
    }
}
