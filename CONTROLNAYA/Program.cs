string [] array = {"Hello", "top", "buy", "origin", "master", ":-)"}; 

string [] newArray = new string [GetQuantity()];
FindWords();


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


