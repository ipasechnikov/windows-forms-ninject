using System.ComponentModel;

namespace WindowsFormsNinject.Models
{
    /// <summary>
    /// Concrete implementation of IModel interface
    /// </summary>
    public abstract class BaseModel : IModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
