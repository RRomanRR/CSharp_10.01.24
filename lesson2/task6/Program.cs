int[] array = { 8, 2, 9, 4, 5 };
int max = array [0];

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);

foreach(int element in array)
{
    if(element > max)
    {
        max = element;
    }
}
Console.WriteLine(max);