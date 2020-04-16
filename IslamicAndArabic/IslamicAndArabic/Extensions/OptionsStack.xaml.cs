using IslamicAndArabic.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OptionsStack : StackLayout
    {
        public static readonly BindableProperty OptionProperty =
            BindableProperty.Create("Option", typeof(string), typeof(OptionsStack));
        public string Option
        {
            get { return (string)GetValue(OptionProperty); }
            set { SetValue(OptionProperty, value); }
        }

        public OptionsStack()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}