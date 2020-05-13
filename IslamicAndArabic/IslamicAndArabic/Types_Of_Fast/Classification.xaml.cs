using IslamicAndArabic.Extensions;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Types_Of_Fast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]
    public partial class Classification : CarouselPage
    {
        IDictionary<string, string> MyQuestionsDico = new Dictionary<string, string>()
        {
            {"Question_1", "Types of fast can be classified into 2 categories. They are" },
            {"Question_2", "Fard Muaiyyan is an obligatory fast observed" },
            {"Question_3", "Which of these is the avowed fast without a particular day in mind?" }
        };

        string[,] MyOptionsArray = new string[,]
        {
            /* Ignore the null
             a1,b1,c1
             a2,b2,c2
             a3,b3,c3
             */
            {null, null, null, null },
            {null, "Fard and Wajib", "Voluntary and Involuntary", "Sunnah and Nafl" },
            {null, "to make up for fast intentionally missed during Ramadan", "to make up for fast accidentally missed during Ramadan", "at a specific time such as the month of Ramadan" },
            {null, "Wajib Ghair Muaiyyan", "Wajib Muaiyyan", "Sunnah Muakkadah" }
        };


        public Classification()
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

            Q1.ProgressBar = 0.67;
            Q2.ProgressBar = 0.83;
            Q3.ProgressBar = 1;
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
            //App.Current.nextQuestion(a3, b3, c3, null, true);
            nextPage(a3,b3,c3);

        }

        public async void nextPage(OptionsStack ax, OptionsStack bx, OptionsStack cx)
        {
            if (ax.PersonalIsChecked)
            {
                var response = await DisplayAlert("Success", "You Passed this Chapter", "Proceed", "No, Thanks");
                if(response == true)
                {
                    await Navigation.PushAsync(new Voluntary());
                }
            }
            else if (!ax.PersonalIsChecked && !bx.PersonalIsChecked && !cx.PersonalIsChecked)
            {
                 await DisplayAlert("Alert", "Choose an Option", "OK");
            }
            else
            {
                await DisplayAlert(null, "Wrong", "Try Again");
            }
        }
    }
}