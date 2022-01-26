namespace CountProviderNS;

public static class UnsafeCountProviderExtensions
{
    public static void IncrementSafe(this CountProvider countProvider)
    {
        Interlocked.Increment(ref countProvider.Count);
    }

    public static Task IncrementSafeAsync(this CountProvider countProvider)
    {
        Interlocked.Increment(ref countProvider.Count);
        return Task.CompletedTask;
    }

    public static void IncrementUnsafe(this CountProvider countProvider)
    {
        countProvider.Count += 1;
    }

    public static Task IncrementUnsafeAsync(this CountProvider countProvider)
    {
        countProvider.Count += 1;
        return Task.CompletedTask;
    }
}