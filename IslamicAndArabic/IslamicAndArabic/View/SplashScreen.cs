using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IslamicAndArabic.View
{
    class SplashScreen : ContentPage
    {
        //https://www.youtube.com/watch?v=I42lb3ENgP8
        Image SplashImage;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var splashContainer = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "transparentIslamicLogo.png"
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            splashContainer.Children.Add(SplashImage);
            this.Content = splashContainer;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await SplashImage.ScaleTo(0.5, 1500);
            await SplashImage.ScaleTo(1, 1500, Easing.Linear);
            await SplashImage.ScaleTo(0.5, 1000, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new DropDownPage());
        }
    }
}
