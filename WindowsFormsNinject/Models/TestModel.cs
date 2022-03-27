namespace WindowsFormsNinject.Models
{
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
                NotifyPropertyChanged("TestText");
            }
        }
    }
}
