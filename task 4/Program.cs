// Задача 3: Не используя рекурсию, выведите первые 
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// double Fibonacci(int n)
// {
//     if(n == 1 || n ==2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 50; i++)
// {
//     System.Console.WriteLine($"{i} + " + Fibonacci(i));
// }

int[] Fibonacci(int number)
{
    int[] array = new int[number];
    array[0]=0;
    array[1]=1;

    for (int i = 2; i < number; i++)
    {
        array[i] = array[i-1] + array [i-2];
    }
    return array;

}

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

int num = InputInt("Input number");
int[] array = Fibonacci(num);
PrintArray(array);