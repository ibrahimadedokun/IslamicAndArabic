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
    [Preserve(AllMembers = true)]
    public partial class StoryContents : ContentPage
    {
        [Preserve(AllMembers = true)]
        public static readonly BindableProperty StoryTitleProperty =
            BindableProperty.Create("StoryTitle", typeof(string), typeof(StoryContents));
        
        [Preserve(AllMembers = true)]
        public string StoryTitle
        {
            get { return (string)GetValue(StoryTitleProperty); }
            set { SetValue(StoryTitleProperty, value); }
        }

        [Preserve(AllMembers = true)]
        public static readonly BindableProperty ContentStoryProperty =
            BindableProperty.Create("ContentStory", typeof(string), typeof(StoryContents));

        [Preserve(AllMembers = true)]
        public string ContentStory
        {
            get { return (string)GetValue(ContentStoryProperty); }
            set { SetValue(ContentStoryProperty, value); }
        }

        [Preserve(AllMembers = true)]
        public static readonly BindableProperty ProgressBarValueProperty =
            BindableProperty.Create("ProgressBarValue", typeof(double), typeof(StoryContents));

        [Preserve(AllMembers = true)]
        public double ProgressBarValue
        {
            get { return (double)GetValue(ProgressBarValueProperty); }
            set { SetValue(ProgressBarValueProperty, value); }
        }

        [Preserve(AllMembers = true)]
        public StoryContents()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}