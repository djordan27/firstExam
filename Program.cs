// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int arrayCount(String[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    if (count == 0)
    {
        count = 1;
    }
    return count;
}

String[] newArray(String[] array, int count)
{
    String[] arrayTreeSize = new String[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayTreeSize[j] = array[i];
            j++;
        }
    }

    if (j == 0)
    {
        arrayTreeSize[j] = "0000";
    }
    return arrayTreeSize;
}
void printArray(String[] array)
{
    char kavuchki = '"';
    if (array[0].Equals("0000"))
    {
        Console.Write("[]");
    }
    else if (array.Length >= 2)
    {

        Console.Write($"[{kavuchki}{array[0]}{kavuchki} ");

        for (int i = 1; i < array.Length - 1; i++)
        {
            Console.Write($"{kavuchki}{array[i]}{kavuchki} ");
        }
        Console.Write($"{kavuchki}{array[array.Length - 1]}{kavuchki}]");
    }
    else
    {
        Console.Write($"[{kavuchki}{array[0]}{kavuchki}]");
    }
    // if(array.Length > 0){
    // Console.Write($"{kavuchki}{array[array.Length - 1]}{kavuchki}]");


    // }
}


String[] firstArray = new String[] { "hello", "2", "world", ":-)" };
int arrayFirstSize = arrayCount(firstArray);
printArray(firstArray);
Console.Write(" -> ");
printArray(newArray(firstArray, arrayFirstSize));

Console.WriteLine();
String[] secondArray = new String[] { "1234", "1567", "-2", "computer science" };
int arraySecondSize = arrayCount(secondArray);
printArray(secondArray);
Console.Write(" -> ");
printArray(newArray(secondArray, arraySecondSize));

Console.WriteLine();
String[] thirdArray = new String[] { "Russia", "Denmark", "Kazan" };
int arrayThirdSize = arrayCount(thirdArray);
printArray(thirdArray);
Console.Write(" -> ");
printArray(newArray(thirdArray, arrayThirdSize));
