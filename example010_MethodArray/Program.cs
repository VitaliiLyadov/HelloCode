int[] array = { 11, 22, 55, 48, 15, 69, 42, 75, 12 };

int n = array.Length;
int find = 55;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}