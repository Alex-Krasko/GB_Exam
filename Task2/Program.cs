int [] arrayA = new int[50];
int minValue = -99;
int maxValue = 100;

int[] FillArray(int[] arr)   // Заполнение массива случайными числами
{
    for(int j=0; j<arr.Length; j++) 
        {
            arr[j] = new Random().Next(minValue,maxValue);
        } 
    return arr;
}

void PrintArray(int[] col)  // Вывод массива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            Console.Write(col[position] +" ");
            position++;
    }  
    Console.WriteLine();
}

int[] SortArray(int[] arr)  // Поиск чисел больше 8 в массиве А и помещение их в массив Б
{
    int n = 0;
    int m = 0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i] > 8) 
        {
            n++;
        }
    }
    int[] arrayB = new int[n];
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i] > 8) 
        {
            arrayB[m] = arr[i];
            m++;
        }
    }
    return arrayB;
}

arrayA = FillArray(arrayA);
Console.Write("First array: ");
PrintArray(arrayA);
Console.Write("Second array: ");
PrintArray(SortArray(arrayA));