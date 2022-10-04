
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numN = int.Parse(Console.ReadLine());


void intervalNumberSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в интервале от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    intervalNumberSum(numM, numN, sum);
}

intervalNumberSum(numM, numN, 0);