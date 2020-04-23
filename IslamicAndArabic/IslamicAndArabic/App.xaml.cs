using IslamicAndArabic.Extensions;
using IslamicAndArabic.FirstView;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        //To use App.Current in other Xaml pages utilizing the methods declared here
        public static new App Current
        {   get {   return (App)Application.Current;    }   }

        #region Next button
        /// <summary>
        /// Navigating to the next question
        /// </summary>
        /// <param name="ax">Correct Option's Stack (this must come first)</param>
        /// <param name="bx">Other Option</param>
        /// <param name="cx">Other Option</param>
        /// <param name="s">(Optional) It's the next question's options stack that should be activated</param>
        /// <param name="isComplete">(Optional) Set to true if this question is the last</param>
        public void nextQuestion(OptionsStack ax, OptionsStack bx, OptionsStack cx, StackLayout s = null, bool isComplete = false)
        {
            if (ax.PersonalIsChecked)
            {
                if (isComplete)
                {
                    Application.Current?.MainPage?.DisplayAlert("Success", "You Passed this Chapter", "Proceed to Next Chapter");
                    //DisplayAlert("Success", "You Passed this Chapter", "Proceed to Next Chapter");
                    return;
                }
                else
                {
                    //Application.Current?.MainPage?.DisplayAlert(info.Title, info.Message, info.Cancel);
                    Application.Current?.MainPage?.DisplayAlert("Mumtaaz", "You got it right", "Swipe to the next question");
                    s.IsEnabled = true;
                    return;
                }
            }
            else if (!ax.PersonalIsChecked && !bx.PersonalIsChecked && !cx.PersonalIsChecked)
            {
                Application.Current?.MainPage?.DisplayAlert("Alert", "Choose an Option", "OK");
            }
            else
            {
                Application.Current?.MainPage?.DisplayAlert(null, "Wrong", "Try Again");
            }
        }
        #endregion

        #region Choosing Option
        /// <summary>
        /// Persist an option selection and prevent multiple
        /// </summary>
        /// <param name="s1">This is the option chosen and should be passed first</param>
        /// <param name="s2">Option not chosen</param>
        /// <param name="s3">Option not chosen</param>
        public void OptionSelected(OptionsStack s1, OptionsStack s2, OptionsStack s3)
        {
            s1.PersonalIsChecked = true;
            s2.PersonalIsChecked = false;
            s3.PersonalIsChecked = false;
        }
        #endregion


    }
}
