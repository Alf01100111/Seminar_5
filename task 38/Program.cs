int[] CreateRndArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(", ", arr));
}

int[] array = new int[8];

PrintArray(CreateRndArray(array));

int MinNumArray(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }               
    }
    return min;
}

int MaxNumArray(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }               
    }
    return max;
}

System.Console.WriteLine($"Разность между максимальным и минимальным элементом = {MaxNumArray(array)-MinNumArray(array)}");

