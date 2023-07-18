// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Promt(string massege)
{
    Console.WriteLine(massege);
    int res=int.Parse(Console.ReadLine()!);
    return res;
}

void SQRT(int a)
{
    int n=1;
    while (n<=a)
    {
        Console.Write(n*n*n+", ");
        n=n+1;
    }
}

int N=Promt("Введите число:");
Console.Write(""+N+" -> ");
SQRT(N);