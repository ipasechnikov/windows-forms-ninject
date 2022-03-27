namespace WindowsFormsNinject.Models
{
    /// <summary>
    /// Conrete implementation of out test model interface
    /// </summary>
    internal class TestModel : BaseModel, ITestModel
    {
        private string _testText;

        public TestModel(string testText)
        {
            _testText = testText;
        }

        public string TestText
        {
            get { return _testText; }
            set
            {
                _testText = value;
                // It's not required to raise a PropertyChanged event in this case
                // There are no listeners for model PropertyChanged event
                // But if there were any, this line of code could come in handy
                NotifyPropertyChanged("TestText");
            }
        }
    }
}
