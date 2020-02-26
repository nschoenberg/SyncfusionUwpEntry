using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncfusionUwpEntry
{
    
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _vm;

        public MainPage()
        {
            InitializeComponent();
            _vm = new MainPageViewModel();
            BindingContext = _vm;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            _vm.Name = "Hello World";
        }
    }
}
