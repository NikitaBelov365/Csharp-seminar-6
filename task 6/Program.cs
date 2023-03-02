// Задача 5: * Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] ArrayCreation(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
    return array;
}

void ArrayFill(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int rowMax(int[,] array)
{
    int maxRow = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
        maxRow += max;
    }
    return maxRow;
}

int columnMin(int[,] array)
{
    int minColumn = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
        int min = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
            }
        }
        minColumn += min;
    }
    return minColumn;
}

int row = InputInt("Input ammount of rows");
int column = InputInt("Input ammount of columns");
int[,] array = ArrayCreation(row, column);
ArrayFill(array);
PrintArray(array);
System.Console.WriteLine($"Ammount of max values in all rows is equal: {rowMax(array)}");
System.Console.WriteLine($"Ammount of min values in all columns is equal: {columnMin(array)}");
System.Console.WriteLine($"Diffrance between ammounts of max and min is equal: {rowMax(array)-columnMin(array)}");

