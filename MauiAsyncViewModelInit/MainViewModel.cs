using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAsyncViewModelInit;

[ObservableObject]
public partial class MainViewModel
{
    private readonly DataService dataService;

    [ObservableProperty]
    private List<string> items = new();

    [ObservableProperty]
    private bool loading = true;

    [ObservableProperty]
    private bool hasError = false;

    public MainViewModel(DataService dataService)
    {
        this.dataService = dataService;
    }

    [RelayCommand]
    private async Task InitAsync()
    {
        Loading = true;
        HasError = false;

        try
        {
            Items = await dataService.LoadItems();
        }
        catch
        {
            HasError = true;
        }
        finally
        {
            Loading = false;
        }
    }
}
