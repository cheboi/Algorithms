public int[] SortArray(int[] array, int size)
{
    if (size <= 1)
        return array;

    for (int i = size / 2 - 1; i >= 0; i--)
    {
        Heapify(array, size, i);
    }

    for (int i = size - 1; i >= 0; i--)
    {
        var tempVar = array[0];
        array[0] = array[i];
        array[i] = tempVar;

        Heapify(array, i, 0);
    }

    return array;
}