int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X первой точки: ");
int y2 = ReadInt("Введите координату Y первой точки: ");
int z2 = ReadInt("Введите координату Z первой точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double Length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {Length}");

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
