using System;
using System.Collections;
using System.Collections.Generic;

namespace UserCode;

public class Sort
{
    #region Algorithm
    public static void QuickSort<T>(Span<T> list, IComparer<T> comparer)
    {
        if (list.Length <= 1)
            return;

        var pivot = list[^1];
        int front_index = 0;
        int back_index = list.Length - 2;
        while (front_index <= back_index) {
            var comparisonResult = comparer.Compare(list[front_index], pivot);
            if (comparisonResult <= 0) {
                front_index += 1;
            } else {
                Swap(list, front_index, back_index);
                back_index -= 1;
            }
        }
        Swap(list, front_index, list.Length - 1);
        
        QuickSort(list[..front_index], comparer);
        QuickSort(list[(front_index + 1)..], comparer);
    }
    #endregion

    private static void Swap<T>(Span<T> span, int firstIndex, int secondIndex)
    {
        (span[firstIndex], span[secondIndex]) = (span[secondIndex], span[firstIndex]);
    }
}