string [] array = {"Hello", "top", "buy", "origin", "master", ":-)"}; 

string [] newArray = new string [GetQuantity()];
FindWords();
PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);

int GetQuantity()
{
    int indexNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            indexNewArray ++;
        }
    }
    return indexNewArray;
}

void FindWords()
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index ++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i != array.Length - 1) 
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else 
        {
            Console.Write($"\"{array[i]}\"");
        }
    }
    Console.Write("]");
}
