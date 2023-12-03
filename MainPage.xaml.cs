using ForgetMeNot.ViewModels;

namespace ForgetMeNot
{
    public partial class MainPage : ContentPage
    {
        private MainVM mainVM = new MainVM();
        
        public MainPage()
        {
            BindingContext = mainVM;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            mainVM.FullName = "Edowādo Won Hau Peperu Chiburusukī Yonsei";
        }
    }
}
