﻿int size = 5;
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

string[] FindElements(string[] array, int arrSize)
{
    string[] newArray = new string[arrSize];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

int newSize = FindSizeOfArr(arr);
string[] result = FindElements(arr, newSize);
PrintArray(arr);
Console.Write(" --> ");
PrintArray(result);
