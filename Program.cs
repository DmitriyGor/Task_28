/*
Задача 28
Напишите программу, которая принимает на вход число N 
и выдает произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
Console.Write("Enter the number N: "); // Введите число N
int numberN  = Convert.ToInt32(Console.ReadLine());
int product = 1;
if (numberN >= 0)
{
    if(numberN != 0)
    {
            for (int count = 1; count <= numberN; count++)
        {
            product *= count;
        }
        Console.WriteLine($"product of numbers from 1 to {numberN} is equal to:  {product}");
        // произведение чисел от 1 до N равно:
    }
    else
    {
        Console.WriteLine($"the number N cannot be equal to ZERO. Set the number N correctly!!!");
        // число N не может быть равно НУЛЮ. Задайте число N правильно
    }
}
else
{
   Console.WriteLine($"the number N cannot be negative. Set the number N correctly!!!");
   // Число N не может быть отрицательным. Задайте число N правильно
}