// Напишите программу, которая принимает на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Нужно узнать, является ли этот день выходным ");
while (true)
{
    Console.Write("\n Введите номер дня недели  ");
    int num = int.Parse(Console.ReadLine());
    if (num == 0) {break;}
    if (num >= 1 && num <=5)
    {
        Console.Write(" Нет, это не выходной");
    }
    else if (num >=6 && num <= 7)
    {
        Console.Write("Да, это выходной" );
    }
    else Console.Write("Не существует такого дня недели ");
}
