int [] array = {13,24,36,49,50,93,72,81,93};

int n = array.Length;
int find = 93;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}