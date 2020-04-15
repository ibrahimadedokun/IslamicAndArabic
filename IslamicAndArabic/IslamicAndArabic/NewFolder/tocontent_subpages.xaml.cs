using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace list_of_books
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tocontent_subpages : CarouselPage 
    {
        public tocontent_subpages()
        {
            InitializeComponent();
            //carousel.BackgroundImageSource = ImageSource.FromResource("list_of_books.imageees.transparentIslamicLogo.png");
            //carousel2.BackgroundImageSource = ImageSource.FromResource("list_of_books.imageees.transparentIslamicLogo.png");

        }
        async private void kw_but_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Greetings", "Good Morning, how are you doing today", "KK");
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
        }

        private void first_chbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                first_opt_stac.BackgroundColor = Color.FromHex("#EB984E");
                sec_chbox.IsChecked = false;
                sec_opt_stac.BackgroundColor = Color.White;
                third_chbox.IsChecked = false;
                third_opt_stac.BackgroundColor = Color.White;
            }
            else
            {
                first_opt_stac.BackgroundColor = Color.White;
            }
            
        }

        private void sec_chbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                sec_opt_stac.BackgroundColor = Color.FromHex("#EB984E");
                first_chbox.IsChecked = false;
                first_opt_stac.BackgroundColor = Color.White;
                third_chbox.IsChecked = false;
                third_opt_stac.BackgroundColor = Color.White;
            }
            else
            {
                sec_opt_stac.BackgroundColor = Color.White;
            }
               
        }

        private void third_chbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                third_opt_stac.BackgroundColor = Color.FromHex("#EB984E");
                first_chbox.IsChecked = false;
                first_opt_stac.BackgroundColor = Color.White;
                sec_opt_stac.BackgroundColor = Color.White;
                sec_chbox.IsChecked = false;
            }
            else
            {
                third_opt_stac.BackgroundColor = Color.White;
            }
                
        }

        private void third_chbox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                third_opt_stac3.BackgroundColor = Color.FromHex("#EB984E");
                first_chbox3.IsChecked = false;
                first_opt_stac3.BackgroundColor = Color.White;
                sec_opt_stac3.BackgroundColor = Color.White;
                sec_chbox3.IsChecked = false;
            }
            else
            {
                third_opt_stac3.BackgroundColor = Color.White;
            }
        }

        private void sec_chbox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                sec_opt_stac3.BackgroundColor = Color.FromHex("#EB984E");
                first_chbox3.IsChecked = false;
                first_opt_stac3.BackgroundColor = Color.White;
                third_opt_stac3.BackgroundColor = Color.White;
                third_chbox3.IsChecked = false;
            }
            else
            {
                sec_opt_stac3.BackgroundColor = Color.White;
            }
        }

        private void first_chbox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                first_opt_stac3.BackgroundColor = Color.FromHex("#EB984E");
                third_chbox3.IsChecked = false;
                third_opt_stac3.BackgroundColor = Color.White;
                sec_opt_stac3.BackgroundColor = Color.White;
                sec_chbox3.IsChecked = false;
            }
            else
            {
                first_opt_stac3.BackgroundColor = Color.White;
            }
        }

        private void third_chbox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                third_opt_stac2.BackgroundColor = Color.FromHex("#EB984E");
                first_chbox2.IsChecked = false;
                first_opt_stac2.BackgroundColor = Color.White;
                sec_opt_stac2.BackgroundColor = Color.White;
                sec_chbox2.IsChecked = false;
            }
            else
            {
                third_opt_stac2.BackgroundColor = Color.White;
            }
        }

        private void sec_chbox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                sec_opt_stac2.BackgroundColor = Color.FromHex("#EB984E");
                first_chbox2.IsChecked = false;
                first_opt_stac2.BackgroundColor = Color.White;
                third_opt_stac2.BackgroundColor = Color.White;
                third_chbox2.IsChecked = false;
            }
            else
            {
                sec_opt_stac2.BackgroundColor = Color.White;
            }
        }

        private void first_chbox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var res = e.Value;
            if (res == true)
            {
                first_opt_stac2.BackgroundColor = Color.FromHex("#EB984E");
                third_chbox2.IsChecked = false;
                third_opt_stac2.BackgroundColor = Color.White;
                sec_opt_stac2.BackgroundColor = Color.White;
                sec_chbox2.IsChecked = false;
            }
            else
            {
                first_opt_stac2.BackgroundColor = Color.White;
            }
        }

        private void CLICKCKCKKC_Tapped(object sender, EventArgs e)
        {
            if(third_chbox.IsChecked == false)
              DisplayAlert("Action Needed", "Answer previous question", "Okay");
           
        }

        private void en_pg_2_Clicked(object sender, EventArgs e)
        {
            if (third_chbox.IsChecked == true)
            {
                DisplayAlert("Great", "You got it right", "Swipe to next question");
                page2_stac.IsEnabled = true;
                return;
            }
            if (first_chbox.IsChecked == false && sec_chbox.IsChecked == false && third_chbox.IsChecked == false)
                DisplayAlert("Info", "Choose an Option", "ok");
            else
                DisplayAlert(null, "Wrong", "Try Again");
        }

        private void en_pg_3_Clicked(object sender, EventArgs e)
        {
            if(third_chbox2.IsChecked == true)
            {
                DisplayAlert("Great", "You got it right", "Swipe to next question");
                page3_stac.IsEnabled = true;
                return;
            }
            if (first_chbox2.IsChecked == false && sec_chbox2.IsChecked == false && third_chbox2.IsChecked == false)
                DisplayAlert("info", "Choose an Option", "ok");
            else
                DisplayAlert(null, "Wrong", "Try Again");
        }

        private void Check_result_Clicked(object sender, EventArgs e)
        {
            if(third_chbox.IsChecked == true && third_chbox2.IsChecked == true && sec_chbox3.IsChecked == true)
            {
                
                DisplayAlert("Success", "You passed this Chapter", "Proceed to next topic");
                return;
            }

            else
                DisplayAlert(null, "Wrong", "Try Again");
        }

        private void tapgesture_page3_Tapped(object sender, EventArgs e)
        {
            if(third_chbox2.IsChecked == false)
                DisplayAlert("Action Needed", "Answer previous question", "Okay");
        }
    }
}