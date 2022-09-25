//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите любое число: ");
int day = int.Parse(Console.ReadLine()!);

if (day > 0 && day < 8)
{
    if (day == 6 || day == 7);
    Console.Write("Выходной день недели");
}
else 
{
    Console.Write("Не выходной день недели");
}
