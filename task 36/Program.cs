int[] CreateRndArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 11);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(", ", arr));
}

int OddSum(int[] array)
{
    int sum = 0;    
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}    

int[] array = new int[6];
PrintArray(CreateRndArray(array));
System.Console.WriteLine($"Сумма чисел на нечётных позициях {OddSum(array)}");

