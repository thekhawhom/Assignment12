using Assignment12.MVVM.ViewModels;

namespace Assignment12;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
		BindingContext = new CarPageViewModel();
	}
}