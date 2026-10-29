using AwesomeAssertions;
using UserCode;

namespace TestCode;

public class QuickSortTests3
{
    private readonly IComparer<int> comparer = Comparer<int>.Default;

    #region InitialTestSet
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

    #region AdvancedTestSet
    [Fact]
    public void SortedListTest()
    {
        int[] list = [1, 2, 3, 4, 5];

        Sort.QuickSort(list, comparer);

        list.Should().Equal([1, 2, 3, 4, 5]);
    }

    [Fact]
    public void ReversedListTest()
    {
        int[] list = [5, 4, 3, 2, 1];

        Sort.QuickSort(list, comparer);

        list.Should().Equal([1, 2, 3, 4, 5]);
    }

    [Fact]
    public void RandomListSortTest()
    {
        int[] list = [5, 3, 7, 1, 9, 4];

        Sort.QuickSort(list, comparer);

        list.Should().Equal([1, 3, 4, 5, 7, 9]);
    }
    #endregion

    #region FinalTestSet
    [Fact]
    public void SemiStabilityTest()
    {
        (int, string)[] list =
        [
            (5, "1"),
            (3, "2"),
            (6, "3"),
            (8, "4"),
            (5, "5"),
        ];

        Sort.QuickSort(list, Comparer<(int, string)>.Create((left, right) => left.Item1.CompareTo(right.Item1)));

        list.Select(x => x.Item2).Should().Equal(["2", "1", "5", "3", "4"]);
    }
    #endregion
}
