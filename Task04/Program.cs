// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//2,3,7 ->7
//44,5,78 ->78
//22,3,9 ->22

Console.WriteLine("Введите три числа");
int numberА = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberС = Convert.ToInt32(Console.ReadLine());

int max = numberА;

if (numberB > max)
{
    max = numberB;
}
if (numberС > max)
{
    max = numberС;
}
Console.WriteLine ("Наибольшее из введенных чисел ->" + max);