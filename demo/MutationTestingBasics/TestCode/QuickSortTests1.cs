using AwesomeAssertions;
using UserCode;

namespace TestCode;

public class QuickSortTests1
{
    // --- Initial Test Set ---
    #region InitialTestSet
    private readonly IComparer<int> comparer = Comparer<int>.Default;

    [Fact]
    public void EmptyListTest()
    {
        int[] list = [];

        Sort.QuickSort(list, comparer);

        list.Should().BeEmpty();
    }

    [Fact]
    public void SingleElementTest()
    {
        int[] list = [5];

        Sort.QuickSort(list, comparer);

        list.Should().Equal([5]);
    }
    #endregion
}
