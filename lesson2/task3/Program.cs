int N = 10;
int[] array = { 1, 13, 6, 7, 8, 3, 5, 9, 19, 7 };
int i = 0;
int max = array[0];
while (i < N)
{
    if (array[i] > max)
    {
    max = array[i];
    }
    i = i + 1;
}
Console.Write(max);