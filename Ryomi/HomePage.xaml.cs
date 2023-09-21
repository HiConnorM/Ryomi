namespace Ryomi;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomePageViewModel(); // Set the BindingContext
    }
}

