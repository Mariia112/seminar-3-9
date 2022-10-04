/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите  число M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  число N:");
int numN = int.Parse(Console.ReadLine());


int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
return AckermannFunction(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {AckermannFunction(numM, numN)}");