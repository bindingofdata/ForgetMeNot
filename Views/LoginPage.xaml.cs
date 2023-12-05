using ForgetMeNot.ViewModels;

namespace ForgetMeNot.Views;

public partial class LoginPage : ContentPage
{
	LoginVM vm = new LoginVM();

	public LoginPage()
	{
		BindingContext = vm;
		InitializeComponent();
	}
}