//bubble Sort Alogorithm
public static int[] BubbleSort(List<int> listInput)
{
    for (int i = 0; i < listInput.Count; i++)
    {
        for (int j = 0; j < listInput.Count; j++)
        {
            if (listInput[i] < listInput[j])
            {
                var temp = listInput[i];
                listInput[i] = listInput[j];
                listInput[j] = temp;
            }
        }
    }
    
    return listInput.ToArray();
}

//sort method
public int[] SortArray(int[] array)
{
    List<int> sortedList = new List<int>();
    var minValue = array[0];
    var maxValue = array[0];

    if (array == null || array.Length <= 1)
    {
        return array;
    }

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
            maxValue = array[i];
        if (array[i] < minValue)
            minValue = array[i];
    }
    
    var numberOfBuckets = maxValue - minValue + 1;
    List<int>[] bucket = new List<int>[numberOfBuckets];

    for (int i = 0; i < numberOfBuckets; i++) 
    {
        bucket[i] = new List<int>();
    }
       
    for (int i = 0; i < array.Length; i++)
    {
        var selectedBucket = (array[i] / numberOfBuckets);
        bucket[selectedBucket].Add(array[i]);
    }

    for (int i = 0; i < numberOfBuckets; i++)
    {
        int[] temp = BubbleSort(bucket[i]);
        sortedList.AddRange(temp);
    }

    return sortedList.ToArray();
}
