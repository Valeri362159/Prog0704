
//Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое число меньшее.
//а=5, b=7 ->7
//а=2, b=10 ->10
//а=-9, b=-3 ->-3

Console.WriteLine("Введите первое число");
int numberА = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberА > numberB)
{
Console.WriteLine ($"Первое число"  + numberА +  "больше чем второе"  +  numberB);
}
else
{
    Console.WriteLine($"Второе число"  + numberB +  "больше чем первое"  + numberА);
}