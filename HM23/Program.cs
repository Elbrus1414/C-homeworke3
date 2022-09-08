/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

Console.Write($"{num} -> ");
while (count < num)
{
Console.Write($"{Math.Pow((count), 3)}, ");
count++;
}

if (count == num)
{
Console.Write($"{Math.Pow((count), 3)}");
count++;
}
 