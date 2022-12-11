int[] array = { 1, 18, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;  // naiti eto 4islo v massive

int index = 0;// ustanovka i na4alo s4et4ika 

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // esli nujno tolko odin raz
    }
    index = index + 1; // ili index = index++;

}