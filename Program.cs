// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int arrayCount ( String[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) {
            count++;
        }
    }
    return count;
}

String[] newArray(String[] array,int count){
    String[] arrayTreeSize = new String [count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
          if(array[i].Length <= 3) {
            arrayTreeSize[j] = array[i];
            j++;
        }
    }
    return arrayTreeSize;
}
void printArray(String []array){
    char kavuchki = '"';
    Console.Write($"[{kavuchki}{array[0]}{kavuchki}");
    for (int i = 1; i < array.Length - 1; i++)
    {
      Console.Write($" {kavuchki}{array[i]}{kavuchki}");  
    }
    Console.Write($"{kavuchki}{array[array.Length - 1]}{kavuchki}]");
} 

String [] firstArray = new String[] {"hello", "2", "world", ":-)"};
int arraySize = arrayCount(firstArray);
printArray(firstArray);
Console.Write(" -> ");
printArray(newArray(firstArray, arraySize));