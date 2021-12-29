namespace CountProviderNS;

/// <summary>
///     <see cref="CountProvider" /> is needed to test atomic scheduler for races and measure performance in some
///     benchmarks
/// </summary>
public class CountProvider
{
    public ulong Count;
}