int [] arrayA = new int[50];
int minValue = 0;
int maxValue = 100;

void PrintArray(int[] col)
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

int[] FillArray(int[] arr)
{
    for(int j=0; j<arr.Length; j++)   // Заполнение массива случайными числами
        {
            arr[j] = new Random().Next(minValue,maxValue);
        } 
    return arr;
}

int[] SortArray(int[] arr)
{
    int n = 0;
    int m = 0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]%2==0) 
        {
            n++;
        }
    }
    int[] arrayB = new int[n];
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]%2==0) 
        {
            arrayB[m] = arr[i];
            m++;
        }
    }
    
    return arrayB;
}

arrayA = FillArray(arrayA);
Console.Write("First array ");
PrintArray(arrayA);
Console.Write("Second array ");
PrintArray(SortArray(arrayA));
