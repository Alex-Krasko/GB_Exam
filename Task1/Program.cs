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