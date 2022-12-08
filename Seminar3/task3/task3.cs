int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void Sqr(int number)
{
    number = number * number * number;
    Console.Write(number + ", ");
}
int N = EnterData("Введите число N: ");
int i = 1;
while (i <= N)
{
    Sqr(i);
    i++;
}
