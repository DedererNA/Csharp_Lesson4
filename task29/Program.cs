int [] RandArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}

int ArrSize=8;
int ArrRanMin=-10;
int ArrRanMax=10;

int[] array = RandArray(ArrSize, ArrRanMin, ArrRanMax);
Console.WriteLine(string.Join(" ", array));