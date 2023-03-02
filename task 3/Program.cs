// Задача 2: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Converter(int number)
{
    int[] array = new int[Size(number)];
    for (int i = 0; number >= 1; i++)
    {
        if(number%2 == 0) array[i] = 0;
        else array[i] = 1;
        number /= 2;
    }
    return array;
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        Swap(array, i, array.Length - 1 - i);
    }
    return array;
}

void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

int Size(int number)
{
    int size = 0;
    for (int i = 0; number >= 1; i++)
    {
        number /= 2;
        size++;
    }
    return size;
}

void PrintArray(int[] array)
{
    bool start = true;
    foreach (int item in array)
    {
        if(item == 1)
        {
            start = false;
        }
        if(!start) System.Console.Write($"{item} ");
        
    }
    System.Console.WriteLine();
}

int number = InputInt("input number");
int[] array = Converter(number);
PrintArray(array);
int[] revertedArray = Reverse(array);
PrintArray(revertedArray);

