using IslamicAndArabic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    public partial class QuestionsPage : CarouselPage
    {
        IDictionary<string, string> MyQuestionsDico = new Dictionary<string, string>()
        {
            {"Question_1", "What is the young boy's name?" },
            {"Question_2", "Which of these is listed among the Prince's friends?" },
            {"Question_3", "What is the name of the Prince's sword?" }
        };

        string[,] MyOptionsArray = new string[,]
        {
            /* Ignore the null
             a1,b1,c1
             a2,b2,c2
             a3,b3,c3
             */
            {null, null, null, null },
            {null, "Maurice", "Merlin", "Martin" },
            {null, "Sir Lancelittle", "Lady Iguana", "Lady Morgana" },
            {null, "Excalibur", "Excavateur", "Executer" }
        };

        string[] MyStoryTitleArray = new string[]
        {
            null,
            "The Story of a Great Kingdom",
            "Friends/Foes of the Prince",
            "The Beginning of the End"
        };

        public QuestionsPage()
        {
            InitializeComponent();

            a1.Option = MyOptionsArray[1, 1];
            b1.Option = MyOptionsArray[1, 2];
            c1.Option = MyOptionsArray[1, 3];

            a2.Option = MyOptionsArray[2, 1];
            b2.Option = MyOptionsArray[2, 2];
            c2.Option = MyOptionsArray[2, 3];

            a3.Option = MyOptionsArray[3, 1];
            b3.Option = MyOptionsArray[3, 2];
            c3.Option = MyOptionsArray[3, 3];

            Q1.PageQuestion = MyQuestionsDico["Question_1"];
            Q2.PageQuestion = MyQuestionsDico["Question_2"];
            Q3.PageQuestion = MyQuestionsDico["Question_3"];
            
            P1.ProgressBarValue = 0.167;
            P2.ProgressBarValue = 0.33;
            P3.ProgressBarValue = 0.5;
            Q1.ProgressBar = 0.67;
            Q2.ProgressBar = 0.833;
            Q3.ProgressBar = 1;

            P1.StoryTitle = MyStoryTitleArray[1];
            P2.StoryTitle = MyStoryTitleArray[2];
            P3.StoryTitle = MyStoryTitleArray[3];
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

        private void _a3_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(a3, b3, c3);
        }

        private void _b3_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(b3, a3, c3);
        }

        private void _c3_Tapped(object sender, EventArgs e)
        {
            App.Current.OptionSelected(c3, a3, b3);
        }

        private void q1Button_Clicked(object sender, EventArgs e)
        {
            App.Current.nextQuestion(b1, a1, c1, opSTACK2);              
        }

        private void q2Button_Clicked(object sender, EventArgs e)
        {
            App.Current.nextQuestion(c2, a2, b2, opSTACK3);
        }

        private void q3Button_Clicked(object sender, EventArgs e)
        {
            App.Current.nextQuestion(a3, b3, c3, null, true);
        }
    }
}