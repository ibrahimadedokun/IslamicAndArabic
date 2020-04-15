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
    public partial class tocontents : ContentPage
    {
        public tocontents()
        {
            InitializeComponent();


            introbut.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            //intro_dst_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //intro_mth_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //intro_Obj_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");

            kw_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            //kw_dst_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //kw_mth_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //kw_Obj_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");


            cls_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            //cls_dst_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //cls_mth_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //cls_Obj_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");

            gc_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            //gc_dst_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //gc_mth_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //gc_Obj_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");

            fc_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            //dst_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //Obj_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
            //mth_bt.ImageSource = ImageSource.FromResource("list_of_books.imageees.right_arrow.png");
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        //async 
        private void Button_Clicked(object sender, EventArgs e)
        {
           //var response = await DisplayActionSheet(null, null, null , "Reserved",  "Variables", "Operators", "string", "Entrypage");
           // if (response == "Reserved")
           //    await Navigation.PushAsync(new bookentrypage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (fc_dst_bt.IsVisible == false && fc_obj_bt.IsVisible == false && fc_mth_bt.IsVisible == false)
            {
                fc_dst_bt.IsVisible = true;
                fc_obj_bt.IsVisible = true;
                fc_mth_bt.IsVisible = true;
                fc_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxminus.png");
            }
            else if (fc_dst_bt.IsVisible == true && fc_obj_bt.IsVisible == true && fc_mth_bt.IsVisible == true)
            {
                fc_dst_bt.IsVisible = false;
                fc_obj_bt.IsVisible = false;
                fc_mth_bt.IsVisible = false;
                fc_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            }
        }

        private void introbut_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Finish a Topic to activate the next topic", "ok");
            if (intro_dst_bt.IsVisible == false && intro_bksp_bt.IsVisible == false && intro_esc_bt.IsVisible == false)
            {
                intro_dst_bt.IsVisible = true;
                intro_bksp_bt.IsVisible = true;
                intro_esc_bt.IsVisible = true;
                introbut.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxminus.png");
            }
            else
            {
                intro_dst_bt.IsVisible = false;
                intro_bksp_bt.IsVisible = false;
                intro_esc_bt.IsVisible = false;
                introbut.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            }

            //if (intro_Dstc.IsVisible == false && intro_Obj.IsVisible == false && intro_Mth.IsVisible == false)
            //{
            //    intro_Dstc.IsVisible = true;
            //    intro_Obj.IsVisible = true;
            //    intro_Mth.IsVisible = true;
            //    introbut.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxminus.png");
            //}
            //else if (intro_Dstc.IsVisible == true && intro_Obj.IsVisible == true && intro_Mth.IsVisible == true)
            //{
            //    intro_Dstc.IsVisible = false;
            //    intro_Obj.IsVisible = false;
            //    intro_Mth.IsVisible = false;
            //    introbut.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            //}
        }

        async private void topcn_bar_Clicked(object sender, EventArgs e)
        {
           await DisplayActionSheet(null, "go back", null, "View Help", "Send Feedback", "STEM(Programming)", "Technical Support", "Check for Updates", "About");
        }

        private void kw_but_Clicked(object sender, EventArgs e)
        {
            if (kw_dst_bt.IsVisible == false && kw_obj_bt.IsVisible == false && kw_mth_bt.IsVisible == false)
            {
                kw_dst_bt.IsVisible = true;
                kw_obj_bt.IsVisible = true;
                kw_mth_bt.IsVisible = true;
                kw_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxminus.png");
            }
            else if (kw_dst_bt.IsVisible == true && kw_obj_bt.IsVisible == true && kw_mth_bt.IsVisible == true)
            {
                kw_dst_bt.IsVisible = false;
                kw_obj_bt.IsVisible = false;
                kw_mth_bt.IsVisible = false;
                kw_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            }
        }

        private void cls_but_Clicked(object sender, EventArgs e)
        {
            if (cls_dst_bt.IsVisible == false && cls_obj_bt.IsVisible == false && cls_mth_bt.IsVisible == false)
            {
                cls_dst_bt.IsVisible = true;
                cls_obj_bt.IsVisible = true;
                cls_mth_bt.IsVisible = true;
                cls_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxminus.png");
            }
            else if (cls_dst_bt.IsVisible == true && cls_obj_bt.IsVisible == true && cls_mth_bt.IsVisible == true)
            {
                cls_dst_bt.IsVisible = false;
                cls_obj_bt.IsVisible = false;
                cls_mth_bt.IsVisible = false;
                cls_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            }
        }

        private void gc_but_Clicked(object sender, EventArgs e)
        {
            if (gc_dst_bt.IsVisible == false && gc_obj_bt.IsVisible == false && gc_mth_bt.IsVisible == false)
            {
                gc_dst_bt.IsVisible = true;
                gc_obj_bt.IsVisible = true;
                gc_mth_bt.IsVisible = true;
                gc_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxminus.png");
            }
            else if (gc_dst_bt.IsVisible == true && gc_obj_bt.IsVisible == true && gc_mth_bt.IsVisible == true)
            {
                gc_dst_bt.IsVisible = false;
                gc_obj_bt.IsVisible = false;
                gc_mth_bt.IsVisible = false;
                gc_but.ImageSource = ImageSource.FromResource("list_of_books.imageees.64pxplus.png");
            }
        }

        private void kw_dst_bt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new tocontent_subpages());
        }

        async private void intro_esc_bt_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Info", "Stage 1 need to be completed first", "back");
        }
    }
}