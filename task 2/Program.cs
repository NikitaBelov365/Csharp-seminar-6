// Задача 1: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void IsExist(int side1, int side2, int side3)
{
    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2) 
    {
        System.Console.WriteLine($"Triangle with sides: {side1}, {side2}, {side3} is exist");
    }
    else System.Console.WriteLine($"Triangle with sides: {side1}, {side2}, {side3} is not exist");
}

int side1 = InputInt("Input 1st side length");
int side2 = InputInt("Input 2nd side length");
int side3 = InputInt("Input 3rd side length");
IsExist(side1, side2, side3);