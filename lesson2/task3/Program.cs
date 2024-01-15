// int N = 10;
int[] array = { 21, 13, 6, 7, 88, 3, 5, 9, 19, 89 };
int i = 0;
int max = array[0];
while (i < array.Length)
{
    if (array[i] > max)
    {
    max = array[i];
    }
    i = i + 1;
}
Console.Write(max);