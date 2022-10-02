// Напишите программу, которая на выход принимает число и выдаёт, является ли число чётным (Делиться ли оно на 2 без остатка).
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 1)
{
    Console.WriteLine("Число " + n + "Нечётное");

}
else
{
    Console.WriteLine("Число " + n + "Чётное");
}
