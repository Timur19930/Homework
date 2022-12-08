// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int n = int.Parse(Console.ReadLine());
int s = ( n % 100) / 10;
Console.WriteLine(s);
