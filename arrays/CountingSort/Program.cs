public static int GetMaxVal(int[] array, int size)
{
    var maxVal = array[0];

    for (int i = 1; i < size; i++) { 
     if(array[i] > maxVal) 
            maxVal = array[i];
     return maxVal;
    }
}

public int[] CountingSort(int[] array)
{
    var size = array.Length;
    var maxElement = GetMaxVal(array, size);
    var occurrences = new int[maxElement + 1];

    for (int i = 0; i < maxElement + 1; i++)
    {
        occurrences[i] = 0;
    }

    for (int i = 0; i < size; i++)
    {
        occurrences[array[i]]++;
    }

    for (int i = 0, j = 0; i <= maxElement; i++)
    {
        while (occurrences[i] > 0)
        {
            array[j] = i;
            j++;
            occurences[i]--;
        }
    }

    return array;
}
