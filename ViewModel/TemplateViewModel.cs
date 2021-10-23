using System.Windows;
using TemplateSolution.Common;

namespace TemplateSolution
{
    public partial class TemplateViewModel : BaseViewModel
    {
        public TemplateViewModel()
        {
            ExampleText = "Yay, Hello world!";

            // When without parameter - ExampleCommand = new Command(ExampleAction);
            ExampleCommand = new Command(() => ExampleAction("abc"));
        }

        private void ExampleAction(string s)
        {
            MessageBox.Show("Hello, world!", "My App" + s);
        }
    }
}

