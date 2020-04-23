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
    public partial class QuestionsPage : CarouselPage
    {
        string[] MyQuestionsArray = new string[]
        {
            null,
            "What is the young boy's name?",
            "Which of these is listed among the Prince's friends?",
            "What is the name of the Prince's sword?"
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

            Q1.PageQuestion = MyQuestionsArray[1];
            Q2.PageQuestion = MyQuestionsArray[2];
            Q3.PageQuestion = MyQuestionsArray[3];

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


        #region Next Chapter button
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_c1">This is the checkbox of the correct answer</param>
        public void completeSection(CheckBox _c1)
        {
            if(_c1.IsChecked == true)
            {
                DisplayAlert("Success", "You Passed this Chapter", "Proceed to Next Chapter");
                return;
            }
            else
                DisplayAlert(null, "Wrong", "Try Again");
        }
        #endregion

        
        /// <summary>
        /// Persist an option selection and prevent multiple
        /// </summary>
        /// <param name="s1">This is the option chosen and should be passed first</param>
        /// <param name="s2">Option not chosen</param>
        /// <param name="s3">Option not chosen</param>
        private void OptionSelected(OptionsStack s1, OptionsStack s2, OptionsStack s3)
        {
            s1.PersonalIsChecked = true;
            s2.PersonalIsChecked = false;
            s3.PersonalIsChecked = false;
        }

        /// <summary>
        /// Navigating to the next question
        /// </summary>
        /// <param name="ax">Correct Option's Stack (this must come first)</param>
        /// <param name="bx">Other Option</param>
        /// <param name="cx">Other Option</param>
        /// <param name="s">(Optional) It's the next question's options stack that should be activated</param>
        /// <param name="isComplete">(Optional) Set to true if this question is the last</param>
        private void nextQuestion(OptionsStack ax, OptionsStack bx, OptionsStack cx, StackLayout s = null, bool isComplete = false)
        {
            if (ax.PersonalIsChecked)
            {
                if (isComplete)
                {
                    DisplayAlert("Success", "You Passed this Chapter", "Proceed to Next Chapter");
                    return;
                }
                else
                {
                    DisplayAlert("Mumtaaz", "You got it right", "Swipe to the next question");
                    s.IsEnabled = true;
                    return;
                }                
            }
            else if (!ax.PersonalIsChecked && !bx.PersonalIsChecked && !cx.PersonalIsChecked)
            {
                DisplayAlert("Alert", "Choose an Option", "OK");
            }
            else
            {
                DisplayAlert(null, "Wrong", "Try Again");
            }
        }

        private void _a1_Tapped(object sender, EventArgs e)
        {
            OptionSelected(a1, b1, c1);
        }

        private void _b1_Tapped(object sender, EventArgs e)
        {
            OptionSelected(b1, a1, c1);
        }

        private void _c1_Tapped(object sender, EventArgs e)
        {
            OptionSelected(c1, a1, b1);
        }

        private void _a2_Tapped(object sender, EventArgs e)
        {
            OptionSelected(a2, b2, c2);
        }

        private void _b2_Tapped(object sender, EventArgs e)
        {
            OptionSelected(b2, a2, c2);
        }

        private void _c2_Tapped(object sender, EventArgs e)
        {
            OptionSelected(c2, a2, b2);
        }

        private void _a3_Tapped(object sender, EventArgs e)
        {
            OptionSelected(a3, b3, c3);
        }

        private void _b3_Tapped(object sender, EventArgs e)
        {
            OptionSelected(b3, a3, c3);
        }

        private void _c3_Tapped(object sender, EventArgs e)
        {
            OptionSelected(c3, a3, b3);
        }

        private void q1Button_Clicked(object sender, EventArgs e)
        {
            nextQuestion(b1, a1, c1, opSTACK2);              
        }

        private void q2Button_Clicked(object sender, EventArgs e)
        {
            nextQuestion(c2, a2, b2, opSTACK3);
        }

        private void q3Button_Clicked(object sender, EventArgs e)
        {
            nextQuestion(a3, b3, c3, null, true);
        }
    }
}