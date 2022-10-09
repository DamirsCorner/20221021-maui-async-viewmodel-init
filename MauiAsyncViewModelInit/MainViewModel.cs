using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAsyncViewModelInit;

[ObservableObject]
public partial class MainViewModel
{
    private readonly DataService dataService;
    private readonly Task initTask;

    [ObservableProperty]
    private List<string> items = new();

    [ObservableProperty]
    private bool loading = true;

    public MainViewModel(DataService dataService)
    {
        this.dataService = dataService;
        this.initTask = InitAsync();
    }

    private async Task InitAsync()
    {
        Items = await dataService.LoadItems();
        Loading = false;
    }
}
