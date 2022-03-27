namespace WindowsFormsNinject.ViewModels.MyUserControl
{
    public interface IMyUserControlViewModel : IViewModel
    {
        string LabelText { get; set; }
        string TextBoxText { get; set; }
    }
}
