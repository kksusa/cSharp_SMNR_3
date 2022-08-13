Console.WriteLine("Напишите координату Х точки А:");
string? xAstring = Console.ReadLine();
int xA = int.Parse(xAstring!);

Console.WriteLine("Напишите координату Y точки А:");
string? yAstring = Console.ReadLine();
int yA = int.Parse(yAstring!);

Console.WriteLine("Напишите координату Z точки А:");
string? zAstring = Console.ReadLine();
int zA = int.Parse(zAstring!);

Console.WriteLine("Напишите координату Х точки B:");
string? xBstring = Console.ReadLine();
int xB = int.Parse(xBstring!);

Console.WriteLine("Напишите координату Y точки B:");
string? yBstring = Console.ReadLine();
int yB = int.Parse(yBstring!);

Console.WriteLine("Напишите координату Z точки B:");
string? zBstring = Console.ReadLine();
int zB = int.Parse(zBstring!);

double vectorLength = Math.Round(Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2)), 2);
Console.WriteLine("Длина вектора в трёхмерном пространстве равна " + vectorLength + ".");