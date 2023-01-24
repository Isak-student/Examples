void FillArray(int[] collection)
{
    int length = collection.Length; //  длинна массива//
    int index = 0; // позиция индекса (в данном случае 0)//
    while (index < length)
    {
        collection[index] = new Random().Next(1,10); //new Random().Next(1,10) случайное число от 1 до 10//
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; //new int[10] - создай 10 элементов//

FillArray(array);
PrintArray(array);
