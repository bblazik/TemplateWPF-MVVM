using System.Windows.Input;

namespace TemplateSolution
{
    public partial class TemplateViewModel
    {
        private string exampleText;
        public string ExampleText
        {
            get => exampleText;
            set => SetProperty(ref exampleText, value);
        }

        private string exampleText2;
        public string ExampleText2
        {
            get => exampleText2;
            set
            {
                exampleText = value;
                OnPropertyChanged();
                //Some other things...
            }
        }

        public ICommand ExampleCommand { get; }
    }
}
