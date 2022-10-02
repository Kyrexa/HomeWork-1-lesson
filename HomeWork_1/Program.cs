// Задача : На вход принимает 2 числа и выдаёт какое число больше , а какое меньше.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число: " + a +"Больше чем второе" + b);

}
else
{
    Console.WriteLine("Второе число" + b +"Больше чем первое" + a);
}