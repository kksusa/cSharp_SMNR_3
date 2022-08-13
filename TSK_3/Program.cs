Console.WriteLine("Напишите целое число больше 0:");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);
if (number < 1) Console.Write("Число введено неверно.");
else 
{
    Console.WriteLine("Кубы чисел в диапазоне от 1 до " + number + ":");
    for (int i = 1; i <= number; i++) Console.Write(Math.Pow(i, 3) + " ");
}