using IconImageSourceBug.ViewModels;

namespace IconImageSourceBug;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

}
