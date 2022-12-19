int numberA = ReadInt("Введите число А: ");
int numberB = ReadInt("Введите число В: ");
ToDeegree(numberA, numberB);
void ToDeegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int ReadLine(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
