// Metod zapolnenia Massiva

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }


// void PrintArray(int[] col)  //void metod ni4igo ne vozvras4aet, poetomu v konze ne nujno pisat - return
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }


// int[] array = new int[10]; // sozdat novii slu4iainii massiv

// FillArray(array);
// PrintArray(array);






void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)  //void metod ni4igo ne vozvras4aet, poetomu v konze ne nujno pisat - return
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0; // sozdali to gde budet hraniza 4islo

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
    }
    index++;
    return position;
}

int[] array = new int[10]; // sozdat novii slu4iainii massiv

FillArray(array);
array[4] = 4;
array[5] =4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);