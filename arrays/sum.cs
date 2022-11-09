public static int SumArray(int[] arr)
{
    int size = arr.Length;
    int total = 0;
    for (int index = 0; index < size; index++)
    {
        total = total + arr[index];
    }
    return total;
}
public static void Main(string[] args)
{
    int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    Console.WriteLine("Sum of values in array:" +
    SumArray(arr));
}