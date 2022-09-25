//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n);

if(n > 99)
{
    while(n > 999)
    {
        n /= 10;

    }
    Console.Write($"третья цифра числа {n % 10}");
}
else 
{
    Console.Write("Третьей цифры нет");
}

