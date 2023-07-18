// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Coordinate(string massege)
{
    Console.WriteLine(massege);
    int res=int.Parse(Console.ReadLine()!);
    return res;
}

int Ax=Coordinate("Введите координатну Х точки А");
int Ay=Coordinate("Введите координатну Y точки А");
int Az=Coordinate("Введите координатну Z точки А");
int Bx=Coordinate("Введите координатну Х точки B");
int By=Coordinate("Введите координатну Y точки B");
int Bz=Coordinate("Введите координатну Z точки B");

double res=Math.Sqrt((Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay)+(Bz-Az)*(Bz-Az));
Console.WriteLine("Расстояние между точками "+res);