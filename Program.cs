Console.Clear();

string[] stringArray = { "hello", "2", "world", ":-)" };
PrintString(stringArray);
Console.WriteLine();
Console.WriteLine("Элементы с длиной меньше или равной трём символам:");
FindElement(stringArray);

void PrintString(string[] stringArr)
{
    for (int i = 0; i < stringArr.Length; i++)
        Console.Write($"{stringArray[i]} ");
        Console.WriteLine();
}

void FindElement(string[] stringArr)
{
    int count = 0;
    string[] finalArr = new string[stringArr.Length];
    for (int i = 0; i < stringArr.Length; i++)
    {
        if (stringArr[i].Length <= 3)
        {
            finalArr[count] = stringArr[i];
            Console.Write($"{finalArr[count]} ");
            count++;
        }
    }
}

