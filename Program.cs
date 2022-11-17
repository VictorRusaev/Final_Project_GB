Console.Clear();

string[] stringArray = {"hello", "2", "world", ":-)"};
PrintString(stringArray);

void PrintString (string[] StringArr)
{
for (int i = 0; i < stringArray.Length; i++)
    Console.WriteLine(stringArray[i]);
}

