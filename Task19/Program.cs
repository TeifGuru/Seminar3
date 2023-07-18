// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

int GetNumber(string mess)
{
    Console.WriteLine(mess);
    int n = int.Parse(Console.ReadLine()!);
    return n;
}

void Poli(int n)
{
    int a1 = n % 10;
    int a2 = n % 100 / 10;   
    int a3 = n % 1000 / 100;
    int a4 = n % 10000 / 1000;
    int a5 = n / 10000;
    if (a1==a5 && a2==a4)
    {
        Console.WriteLine(""+n+" -> число является палиндромом");
    }
    else
    {
        Console.WriteLine(""+n+" -> число не является палиндромом");
    }
}

int num = GetNumber("Введите пятизначное число");
if (num < 10000 || num > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{
  Poli(num);
}