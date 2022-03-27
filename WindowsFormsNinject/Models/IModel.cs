using System.ComponentModel;

namespace WindowsFormsNinject.Models
{
    /// <summary>
    /// Every model must inherit this base interface implicitly or explicitly
    /// </summary>
    public interface IModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Call this method in setters of descendant classes if you want to notify a property change
        /// </summary>
        /// <param name="propertyName">Name of property that has changed</param>
        void NotifyPropertyChanged(string propertyName);
    }
}
