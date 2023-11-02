using GroupedCollectionViewBug.ViewModels;

namespace GroupedCollectionViewBug;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}