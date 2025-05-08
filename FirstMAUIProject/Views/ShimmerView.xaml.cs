using FirstMAUIProject.ViewModels;
using System.Globalization;
namespace FirstMAUIProject.Views;

public partial class ShimmerView : ContentView
{
	public ShimmerView()
	{
		InitializeComponent();
        BindingContext = new ContactViewModel();
    }
}