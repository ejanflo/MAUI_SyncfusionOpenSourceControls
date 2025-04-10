using FirstMAUIProject.ViewModels;

namespace FirstMAUIProject.Views;

public partial class CarouselView : ContentView
{
	public CarouselView()
	{
		InitializeComponent();
        BindingContext = new CarouselViewModel();
    }
}