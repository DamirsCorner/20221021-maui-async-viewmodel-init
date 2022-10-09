namespace MauiAsyncViewModelInit;
public class DataService
{
    public async Task<List<string>> LoadItems()
    {
        await Task.Delay(5000).ConfigureAwait(false); // prevent deadlock
        return Enumerable.Range(1, 10).Select(i => $"Item {i}").ToList();
    }
}
