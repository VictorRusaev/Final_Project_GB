Console.Clear();

string[] stringArray = { "hello", "2", "world", ":-)" };
PrintString(stringArray);
Console.WriteLine();
FindElement(stringArray);

void PrintString(string[] stringArr)
{
    for (int i = 0; i < stringArr.Length; i++)
        Console.WriteLine(stringArray[i]);
}

void FindElement(string[] stringArr)
{
    int count = 0;
    string[] finalArr = new string[4];
    for (int i = 0; i < stringArr.Length; i++)
    {
        if (stringArr[i].Length <= 3)
        {
            finalArr[count] = stringArr[i];
            Console.WriteLine(finalArr[count]);
            count++;
        }
    }
}

