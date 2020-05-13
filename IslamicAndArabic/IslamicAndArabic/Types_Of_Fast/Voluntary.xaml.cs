using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Types_Of_Fast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    public partial class Voluntary : CarouselPage
    {
        IDictionary<string, string> MyQuestionsDico = new Dictionary<string, string>()
        {
            {"Question_1", "Which of these is not a type of Sunnah fast?" },
            {"Question_2", "Voluntary fasts are " },
        };

        string[,] MyOptionsArray = new string[,]
        {
            {null, null, null, null },
            {null, "11th - 13th of Dhul-Hijjah", "8 days in the first 10 days of Dhul-Hijjah", "Every Mondays and Thursdays" },
            {null, "Fard and Wajib", "Sunnah and Nafl", "Sunnah and Fard" }
        };

        string[] MyStoryTitleArray = new string[]
        {
            null,
            "Sunnah and Nafl"
        };


        public Voluntary()
        {
            InitializeComponent();

            a1.Option = MyOptionsArray[1, 1];
            b1.Option = MyOptionsArray[1, 2];
            c1.Option = MyOptionsArray[1, 3];

            a2.Option = MyOptionsArray[2, 1];
            b2.Option = MyOptionsArray[2, 2];
            c2.Option = MyOptionsArray[2, 3];

            P1.ProgressBarValue = 0.33;
            Q1.ProgressBar = 0.66;
            Q2.ProgressBar = 1;

            Q1.PageQuestion = MyQuestionsDico["Question_1"];
            Q2.PageQuestion = MyQuestionsDico["Question_2"];

            P1.StoryTitle = MyStoryTitleArray[1];
        }

        private void _a1_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(a1, b1, c1);
        }

        private void _b1_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(b1, a1, c1);
        }

        private void _c1_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(c1, a1, b1);
        }

        private void _a2_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(a2, b2, c2);
        }

        private void _b2_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(b2, a2, c2);
        }

        private void _c2_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(c2, a2, b2);
        }

        private void q1Button_Clicked(object sender, EventArgs e)
        {
            App.Current.nextQuestion(a1, b1, c1, opSTACK2);
        }

        private void q2Button_Clicked(object sender, EventArgs e)
        {
            App.Current.nextQuestion(b2, a2, c2, null, true);
        }
    }
}