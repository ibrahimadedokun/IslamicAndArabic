
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Extensions
{
    [ContentProperty("Child")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoryPageTemplate : ContentView
    {
        public StoryPageTemplate()
        {
            InitializeComponent();
        }
        public double ProgressBarValue
        {
            get => ProgBar.Progress;
            set => ProgBar.Progress = value;
        }

        public View Body
        {
            get => page_body.Content;
            set => page_body.Content = value;
        }
    }
}