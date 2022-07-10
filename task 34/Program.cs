
int[] CreateRndArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(", ", arr));
}

int[] array = new int[8];
PrintArray(CreateRndArray(array));

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Четных чисел в массиве {count}");