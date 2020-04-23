using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Extensions
{
    [ContentProperty("Child")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionsPageTemplate : ContentView
    {
        public QuestionsPageTemplate()
        {
            InitializeComponent();
        }

        public double ProgressBar
        {
            get => ProgressBarValue.Progress;
            set => ProgressBarValue.Progress = value;
        }

        public string PageQuestion
        {
            get => Question.Text;
            set => Question.Text = value;
        }

        public View Body
        {
            get => OptionsBodyContent.Content;
            set => OptionsBodyContent.Content = value;
        }

        public View Button
        {
            get => PageButtonSection.Content;
            set => PageButtonSection.Content = value;
        }
    }
}