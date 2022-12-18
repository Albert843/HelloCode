int[] array = {10, 12, 37, 4, 55, 6, 37, 18};
int n = array.Length;
int find = 37;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
