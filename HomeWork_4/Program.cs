﻿// Написать программу, которая на входе принимает число (N), а на выходе показывает всё чётные числа от 1 до N.
int i = 1;
bool not = true;
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + n);
while (i <= n)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
not = false;
 }
i++;
}
if (not)
 {
Console.WriteLine("Нет чётных чисел!");
}