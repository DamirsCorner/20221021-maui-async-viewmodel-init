using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAsyncViewModelInit;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty]
    private List<string> items = new();

    public MainViewModel(DataService dataService)
    {
        items = dataService.LoadItems().Result;
    }
}
