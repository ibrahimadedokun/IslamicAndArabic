using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslamicAndArabic.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Preserve(AllMembers = true)]
    public partial class OptionsStack : StackLayout
    {       
        public static readonly BindableProperty OptionProperty =
            BindableProperty.Create("Option", typeof(string), typeof(OptionsStack));
        public string Option
        {
            get { return (string)GetValue(OptionProperty); }
            set { SetValue(OptionProperty, value); }
        }

        public static readonly BindableProperty PersonalIsCheckedProperty =
            BindableProperty.Create("PersonalIsChecked", typeof(bool), typeof(OptionsStack));
        public bool PersonalIsChecked
        {
            get { return (bool)GetValue(PersonalIsCheckedProperty); }
            set { SetValue(PersonalIsCheckedProperty, value); }
        }
        

        public OptionsStack()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}