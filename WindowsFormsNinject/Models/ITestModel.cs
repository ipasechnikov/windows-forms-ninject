namespace WindowsFormsNinject.Models
{
    /// <summary>
    /// Our test model interface with some test data
    /// In real life it can be a User model, a Product model or whatever
    /// </summary>
    public interface ITestModel : IModel
    {
        /// <summary>
        /// Data that will be used by viewmodel
        /// Again, in real life it can be a username, password, product count etc
        /// </summary>
        string TestText { get; set; }
    }
}
