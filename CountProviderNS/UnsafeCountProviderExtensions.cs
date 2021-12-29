namespace CountProviderNS;

public static class UnsafeCountProviderExtensions
{
    public static void IncrementSafe(this CountProvider countProvider)
    {
        Interlocked.Increment(ref countProvider.Count);
    }

    public static void IncrementUnsafe(this CountProvider countProvider)
    {
        countProvider.Count += 1;
    }
}