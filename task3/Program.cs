// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите первое число");
int num1 = Int32.Parse(Console.ReadLine());
int x = num1%2;
if ( x == 0)
{
    Console.WriteLine("да");
}else
{
    Console.WriteLine("нет");
}
