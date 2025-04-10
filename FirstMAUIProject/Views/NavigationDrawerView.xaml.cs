namespace FirstMAUIProject.Views;

public partial class NavigationDrawerView : ContentView
{
	public NavigationDrawerView()
	{
		InitializeComponent();
		BindingContext = new NavigationDrawerViewModel();
    }

    private void hamburgerButton_Clicked(object sender, EventArgs e)
    {
        navigationDrawer.ToggleDrawer();
    }
}