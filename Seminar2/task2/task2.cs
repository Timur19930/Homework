// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear(); 
Console.WriteLine("Введите число "); 
int n = int.Parse(Console.ReadLine());
if ( n < 100 )  
{ 
    Console.Write("Третьей цифры не существует "); 
} 
else 
{
    while ( n >= 999 ) 
    { 
        n = n / 10; 
    }
    Console.WriteLine(n % 10);
}
