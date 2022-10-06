// Напишите программу, которая принимает на вход трехзначное число на выходе
// показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
string num11 = Console.ReadLine();
int num1 = int.Parse(num11);

void secondNum(int a)
{
    string num = a.ToString();
    int second = int.Parse(num[1].ToString());

    if (a > 99)
        Console.WriteLine(second);
    else
        Console.WriteLine("Вы ввели не трехзначное число");
}

secondNum(num1);
