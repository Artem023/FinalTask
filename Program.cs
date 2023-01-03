int size = 5;
string [] arr = new string [size];
arr[0] = "12";
arr[1] = "Hi!";
arr [2] = "HEllo!";
arr [3] = "How Are YOU";
arr [4] = "!";

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

int FindSizeOfArr(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
