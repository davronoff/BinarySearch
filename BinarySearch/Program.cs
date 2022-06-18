class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
        Console.Write($"We have from {(arr.Length - arr.Length) - 1} to {arr.Length} numbers: ");
        int itemforfind = int.Parse(Console.ReadLine());
        if(itemforfind > arr.Length)
        {
            Console.WriteLine($"This item not found");
        }
        else
        {
            if (BinarySearch(arr, 0, arr.Length, itemforfind) != -1);
            {
                Console.WriteLine($"Item found: {itemforfind}");
            }
        }
    }
    static int BinarySearch(int[] arr, int left, int right, int itemforfind)
    {
        int middle = (left + right) / 2;
        if (arr[middle] == itemforfind)
        {
            return itemforfind;
        }
        else
        {
            if (arr[middle] > itemforfind)
            {
                return BinarySearch(arr, left, middle - 1, itemforfind);
            }
            else
            {
                return BinarySearch(arr, right, middle + 1, itemforfind);
            }
        }
    }
}
