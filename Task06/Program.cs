﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine("Число " + number + " является: НЕЧЕТНЫМ");
}
else
{
    Console.WriteLine("Число " + number + " является: ЧЕТНЫМ");
}