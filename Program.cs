string[] FillArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

int CountStringSymbol(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    return n;
}

string[] FillNewArray(string[] OldArray, string[] NewArray)
{
    int j = 0;
    for (int i = 0; i < OldArray.Length; i++)
    {
        if (OldArray[i].Length <= 3)
        {
            NewArray[j] = OldArray[i];
            j++;
        }
    }
    return NewArray;
}

void PrintArray(string[] stringArray)
{
    int j = 1;
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]}");
        if (i < j && j != stringArray.Length)
        {
            Console.Write(",");
        }
        j++;
    }
    Console.Write("]");
}


Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[m];

FillArray(Array);
string[] NewArray = new string[CountStringSymbol(Array)];
PrintArray(FillNewArray(Array, NewArray));