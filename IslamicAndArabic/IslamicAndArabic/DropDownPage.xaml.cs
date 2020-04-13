using IslamicAndArabic.MarkupExtensions;
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
    public partial class DropDownPage : ContentPage
    {
        public DropDownPage()
        {
            InitializeComponent();
        }

        private void firstButton_Clicked(object sender, EventArgs e)
        {
            if(firstStackOne.IsVisible == true && firstStackTwo.IsVisible == true && firstStackThree.IsVisible == true)
            {
                firstButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.plus64px.png");
                firstStackOne.IsVisible = false;
                firstStackTwo.IsVisible = false;
                firstStackThree.IsVisible = false;
            }
            else if (firstStackOne.IsVisible == false && firstStackTwo.IsVisible == false && firstStackThree.IsVisible == false)
            {
                firstButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.minus64px.png");
                firstStackOne.IsVisible = true;
                firstStackTwo.IsVisible = true;
                firstStackThree.IsVisible = true;
            }
        }

        private void secondButton_Clicked(object sender, EventArgs e)
        {
            if (secondStackOne.IsVisible == true && secondStackTwo.IsVisible == true && secondStackThree.IsVisible == true && secondStackFour.IsVisible == true)
            {
                secondButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.plus64px.png");
                secondStackOne.IsVisible = false;
                secondStackTwo.IsVisible = false;
                secondStackThree.IsVisible = false;
                secondStackFour.IsVisible = false;
            }
            else if (secondStackOne.IsVisible == false && secondStackTwo.IsVisible == false && secondStackThree.IsVisible == false && secondStackFour.IsVisible == false)
            {
                secondButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.minus64px.png");
                secondStackOne.IsVisible = true;
                secondStackTwo.IsVisible = true;
                secondStackThree.IsVisible = true;
                secondStackFour.IsVisible = true;
            }
        }

        private void thirdButton_Clicked(object sender, EventArgs e)
        {
            if (thirdStackOne.IsVisible == true && thirdStackTwo.IsVisible == true && thirdStackThree.IsVisible == true)
            {
                thirdButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.plus64px.png");
                thirdStackOne.IsVisible = false;
                thirdStackTwo.IsVisible = false;
                thirdStackThree.IsVisible = false;
            }
            else if (thirdStackOne.IsVisible == false && thirdStackTwo.IsVisible == false && thirdStackThree.IsVisible == false)
            {
                thirdButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.minus64px.png");
                thirdStackOne.IsVisible = true;
                thirdStackTwo.IsVisible = true;
                thirdStackThree.IsVisible = true;
            }
        }

        private void fourthButton_Clicked(object sender, EventArgs e)
        {
            if (fourthStackOne.IsVisible == true)
            {
                fourthButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.plus64px.png");
                fourthStackOne.IsVisible = false;
            }
            else if (fourthStackOne.IsVisible == false)
            {
                fourthButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.minus64px.png");
                fourthStackOne.IsVisible = true;
            }
        }

        private void fifthButton_Clicked(object sender, EventArgs e)
        {
            if (fifthStackOne.IsVisible == true && fifthStackTwo.IsVisible == true)
            {
                fifthButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.plus64px.png");
                fifthStackOne.IsVisible = false;
                fifthStackTwo.IsVisible = false;
            }
            else if (fifthStackOne.IsVisible == false && fifthStackTwo.IsVisible == false)
            {
                fifthButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.minus64px.png");
                fifthStackOne.IsVisible = true;
                fifthStackTwo.IsVisible = true;
            }
        }

        private void sixthButton_Clicked(object sender, EventArgs e)
        {
            if (sixthStackOne.IsVisible == true && sixthStackTwo.IsVisible == true && sixthStackThree.IsVisible == true)
            {
                sixthButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.plus64px.png");
                sixthStackOne.IsVisible = false;
                sixthStackTwo.IsVisible = false;
                sixthStackThree.IsVisible = false;
                sixthStackFour.IsVisible = false;
                sixthStackFive.IsVisible = false;
                sixthStackSix.IsVisible = false;
            }
            else if (sixthStackOne.IsVisible == false && sixthStackTwo.IsVisible == false && sixthStackThree.IsVisible == false)
            {
                sixthButton.ImageSource = ImageSource.FromResource("IslamicAndArabic.images.minus64px.png");
                sixthStackOne.IsVisible = true;
                sixthStackTwo.IsVisible = true;
                sixthStackThree.IsVisible = true;
                sixthStackFour.IsVisible = true;
                sixthStackFive.IsVisible = true;
                sixthStackSix.IsVisible = true;
            }
        }

        async private void fourthOne_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void fifthOne_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void fifthTwo_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void sixthOne_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void sixthTwo_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void sixthThree_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void sixthFour_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void sixthFive_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void sixthSix_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void thirdOne_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void thirdTwo_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void thirdThree_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void firstOne_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void firstTwo_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void firstThree_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void secondOne_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void secondTwo_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void secondThree_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        async private void secondFour_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        private void firstFour_Tapped(object sender, EventArgs e)
        {

        }
    }
}