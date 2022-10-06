// Напишите программу, которая выводит третью цифру заданного числа,
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное число");
string num11 = Console.ReadLine();
int num1 = int.Parse(num11);

void thirdNum(int a)
{
    string num = a.ToString();
    int third = int.Parse(num[2].ToString());
    Console.WriteLine(third);
}

if (num1 > 99)
    thirdNum(num1);
else
    Console.WriteLine($"В числе {num1} нет третьей цифры");
