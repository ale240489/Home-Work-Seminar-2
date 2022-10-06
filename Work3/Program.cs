// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли это день выходным.

Console.WriteLine("Введите цифру от одного до 7");
string num11 = Console.ReadLine();
int num1 = int.Parse(num11);

void dayOfWeak (int a)
{
    int numberDay = a;
    if (a >= 1 && a<=5)
        Console.WriteLine("рабочий");
    else if (a > 5 && a < 8)
        Console.WriteLine("выходной");
    else
        Console.WriteLine("Ведено неверное число");
    
}
dayOfWeak(num1);
