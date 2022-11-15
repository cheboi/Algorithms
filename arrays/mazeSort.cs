public static int GetMaxVal(int[] array, int size)
{
    var maxVal = array[0];

    for (int i = 1; i < size; i++)
        if (array[i] > maxVal)
            maxVal = array[i];

    return maxVal;
}

public int[] RadixSort (int[] array, int size)
{
    var maxVal = GetMaxVal(array, size);

    for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
        CountingSort(array, size, exponent);

    return array;
}