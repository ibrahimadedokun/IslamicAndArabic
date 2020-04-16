using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    public partial class MyStackLayout : StackLayout
    {
        //Standard Xamarin Protocol for Binding Property (Bindable Infrastructure)
        [Preserve(AllMembers = true)]
        public static readonly BindableProperty TabDescriptionProperty =
            BindableProperty.Create("TabDescription", typeof(string), typeof(MyStackLayout));
        [Preserve(AllMembers = true)]
        public string TabDescription 
        {
            get { return (string)GetValue(TabDescriptionProperty); }
            set { SetValue(TabDescriptionProperty, value); }
        }

        [Preserve(AllMembers = true)]
        public MyStackLayout()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}