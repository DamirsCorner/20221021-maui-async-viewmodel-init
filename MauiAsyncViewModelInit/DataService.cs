namespace MauiAsyncViewModelInit;
public class DataService
{
    private bool fail = true;

    public async Task<List<string>> LoadItems()
    {
        await Task.Delay(5000);
        if (fail)
        {
            fail = false;
            throw new Exception("Failed to load items");
        }
        return Enumerable.Range(1, 10).Select(i => $"Item {i}").ToList();
    }
}
