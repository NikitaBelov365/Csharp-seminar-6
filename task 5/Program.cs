//  Задача 4: Напишите программу, которая будет создавать 
//  копию заданного массива с помощью поэлементного копирования.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayCreation(int number)
{
    Random rnd = new Random();
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

int[] ArrayCopy(int[] array, int number)
{
    int[] arrayCopy = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

int number = InputInt("Input number");
int[] array = ArrayCreation(number);
int[] arrayCopy = ArrayCopy(array, number);
PrintArray(arrayCopy);
PrintArray(array);