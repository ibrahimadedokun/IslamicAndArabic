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
    }
}