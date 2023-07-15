//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
    int digit3 = number / 100 % 10;
    Console.WriteLine ($"Третья цифра заданного числа - {digit3}");
}
else
{
    Console.WriteLine ($"Третьей цифры нет");
}