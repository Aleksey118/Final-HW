void PrintArray(string[] array)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
}

string[] GetArrayLessThenFourNum(string[] array)
{
    string[] filteredArray = new string[array.Length];
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            filteredArray[size] = array[i];
            size++;
        }
    }
    Array.Resize(ref filteredArray, size);
    return filteredArray;
}

string[] GetArray(int length)
{
    string[] origArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Enter element number {i + 1}: ");
        origArray[i] = Console.ReadLine();
    }
    return origArray;
}

int GetArrayLength(string text)
{
    Console.Write(text);
    int length = int.Parse(Console.ReadLine());
    return length;
}

int length = GetArrayLength("Enter array length: ");
string[] originalArray = GetArray(length);
string[] filteredArray = GetArrayLessThenFourNum(originalArray);
Console.WriteLine();
PrintArray(originalArray);
Console.Write(" -> ");
PrintArray(filteredArray);