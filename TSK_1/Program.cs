Console.WriteLine("Напишите пятизначное число больше нуля:");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);
int firstDigit = number / 10000;
if (firstDigit <= 0 || firstDigit >= 10)
{
    Console.WriteLine("Число введено неверно.");
    return;
}
int secondDigit = number / 1000 % 10;
int fourthDigit = number / 10 % 10;
int fifthDigit = number % 10;
if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.WriteLine("Число является палиндромом.");
else Console.WriteLine("Число не является палиндромом.");