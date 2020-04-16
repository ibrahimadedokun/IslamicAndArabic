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
        public QuestionsPage()
        {
            InitializeComponent();
        }

        #region Check box ticking and unticking
        /// <summary>
        ///
        /// </summary>
        /// <param name="arg">The CheckedChangedEventArgs which is e by default from the generated method</param>
        /// <param name="s1">This is the active stack layout for the checkbox. It should be declared first</param>
        /// <param name="s2">The other stacklayout option, order does not matter for the remaining checkboxes</param>
        /// <param name="s3">The other stacklayout option, order does not matter for the remaining checkboxes</param>
        /// <param name="l1">This is the active stack layout for the checkbox. It should be declared first</param>
        /// <param name="l2">The other stacklayout option, order does not matter for the remaining checkboxes</param>
        /// <param name="l3">The other stacklayout option, order does not matter for the remaining checkboxes</param>
        /// <param name="c1">This is the active stack layout for the checkbox. It should be declared first</param>
        /// <param name="c2">The other stacklayout option, order does not matter for the remaining checkboxes</param>
        /// <param name="c3">The other stacklayout option, order does not matter for the remaining checkboxes</param>
        public void checkBoxBehaviour(CheckedChangedEventArgs arg, StackLayout s1, StackLayout s2, StackLayout s3, Label l1, Label l2, Label l3, CheckBox c1, CheckBox c2, CheckBox c3)
        {
            bool status = arg.Value;
            if (status == true)
            {
                optionChecked(s1, l1, c2, c3);
                optionUnchecked(s2, l2);
                optionUnchecked(s3, l3);

            }
            else
                optionUnchecked(s1, l1);
        }
        
        public void optionChecked(StackLayout S, Label L, CheckBox C1, CheckBox C2)
        {
            S.BackgroundColor = Color.FromHex("#795548");
            L.FontAttributes = FontAttributes.Bold;
            L.TextColor = Color.Wheat;
            C1.IsChecked = false;
            C2.IsChecked = false;
        }

        public void optionUnchecked(StackLayout _S, Label _L)
        {
            _S.BackgroundColor = Color.Default;
            _L.FontAttributes = FontAttributes.None;
            _L.TextColor = Color.Black;
        }

        #endregion


        #region Submit button for the next question
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch1">The checkbox for the correct answer. This should be declared first</param>
        /// <param name="ch2">Other checkboxes order does not matter</param>
        /// <param name="ch3">Other checkboxes order does not matter</param>
        /// <param name="st">The next page's stacklayout which should be activated if a correct option is chosen</param>
        public void nextQue(CheckBox ch1, CheckBox ch2, CheckBox ch3, StackLayout st)
        {
            if (ch1.IsChecked == true)
            {
                DisplayAlert("Mumtaaz", "You got it right", "Swipe to the next question");
                st.IsEnabled = true;
                return;
            }
            else if (ch1.IsChecked == false && ch2.IsChecked == false && ch3.IsChecked == false)
                DisplayAlert("Alert", "Choose an Option", "OK");
            else
                DisplayAlert(null, "Wrong", "Try Again");
        }
        #endregion

        #region Next section button
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

        private void checkA1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionA1, optionB1, optionC1, ansA1, ansB1, ansC1, checkA1, checkB1, checkC1);
        }

        private void checkC1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionC1, optionB1, optionA1, ansC1, ansB1, ansA1, checkC1, checkB1, checkA1);
        }        

        private void checkB1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionB1, optionA1, optionC1, ansB1, ansA1, ansC1, checkB1, checkA1, checkC1);
        }

        private void nextQ2_Clicked(object sender, EventArgs e)
        {
            nextQue(checkB1, checkA1, checkC1, answerOptionsQ2);
        }

        private void checkC2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionC2, optionB2, optionA2, ansC2, ansB2, ansA2, checkC2, checkB2, checkA2);
        }

        private void checkB2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionB2, optionA2, optionC2, ansB2, ansA2, ansC2, checkB2, checkA2, checkC2);
        }

        private void checkA2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionA2, optionB2, optionC2, ansA2, ansB2, ansC2, checkA2, checkB2, checkC2);
        }

        private void nextQ3_Clicked(object sender, EventArgs e)
        {
            nextQue(checkC2, checkA2, checkB2, answerOptionsQ3);
        }

        private void checkB3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionB3, optionA3, optionC3, ansB3, ansA3, ansC3, checkB3, checkA3, checkC3);
        }

        private void checkA3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionA3, optionB3, optionC3, ansA3, ansB3, ansC3, checkA3, checkB3, checkC3);
        }

        private void checkC3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkBoxBehaviour(e, optionC3, optionB3, optionA3, ansC3, ansB3, ansA3, checkC3, checkB3, checkA3);
        }

        private void finished_Clicked(object sender, EventArgs e)
        {
            completeSection(checkA3);
        }
    }
}