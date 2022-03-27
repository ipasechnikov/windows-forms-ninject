using System.ComponentModel;

namespace WindowsFormsNinject.ViewModels
{
    /// <summary>
    /// Every model must inherit this base interface implicitly or explicitly
    /// </summary>
    public interface IViewModel : INotifyPropertyChanged
    {
        void NotifyPropertyChanged(string propertyName);
    }
}
