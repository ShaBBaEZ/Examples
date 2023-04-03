int[] array = {1,12,31,4,15,16,17,4,18};

int n = array.Length;//Length возвращает кол-во элементов массива.
int find = 4;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;// прерывание после нахождения первого.
    }
    index++;//index = index + 1;
}