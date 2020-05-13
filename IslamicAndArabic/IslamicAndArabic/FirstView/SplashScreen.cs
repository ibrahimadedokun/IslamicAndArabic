using Xamarin.Forms;

namespace IslamicAndArabic.FirstView
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
                Source = "solace_logo_480.png"
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            splashContainer.Children.Add(SplashImage);
            this.Content = splashContainer;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await SplashImage.ScaleTo(0.5, 750);
            await SplashImage.ScaleTo(1, 500, Easing.Linear);
            await SplashImage.ScaleTo(0.5, 750, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new DropDownPage());
        }
    }
}
