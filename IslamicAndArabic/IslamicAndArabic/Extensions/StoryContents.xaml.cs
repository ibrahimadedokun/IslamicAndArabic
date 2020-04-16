using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoryContents : ContentPage
    {
        public static readonly BindableProperty HeadingProperty =
            BindableProperty.Create("Heading", typeof(string), typeof(StoryContents));
        public string Heading
        {
            get { return (string)GetValue(HeadingProperty); }
            set { SetValue(HeadingProperty, value); }
        }

        public static readonly BindableProperty StoryTitleProperty =
            BindableProperty.Create("StoryTitle", typeof(string), typeof(StoryContents));
        public string StoryTitle
        {
            get { return (string)GetValue(StoryTitleProperty); }
            set { SetValue(StoryTitleProperty, value); }
        }

        public static readonly BindableProperty ContentStoryProperty =
            BindableProperty.Create("ContentStory", typeof(string), typeof(StoryContents));
        public string ContentStory
        {
            get { return (string)GetValue(ContentStoryProperty); }
            set { SetValue(ContentStoryProperty, value); }
        }

        public static readonly BindableProperty ProgressBarValueProperty =
            BindableProperty.Create("ProgressBarValue", typeof(double), typeof(StoryContents));
        public double ProgressBarValue
        {
            get { return (double)GetValue(ProgressBarValueProperty); }
            set { SetValue(ProgressBarValueProperty, value); }
        }

        public StoryContents()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}