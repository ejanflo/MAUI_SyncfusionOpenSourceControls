using FirstMAUIProject.ViewModels;

namespace FirstMAUIProject;

public partial class LoginPage : ContentPage
{

    private readonly LoginPageViewModel loginVM;

    public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginPageViewModel();
    }
}