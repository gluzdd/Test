string[] array = new string[4] {"Hello", "2", "world", ":-)"};
string[] secondArray = new string[array.Length];

void GetShortWordsArray(string[] array, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            secondArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetShortWordsArray(array, secondArray);
PrintArray(secondArray);
