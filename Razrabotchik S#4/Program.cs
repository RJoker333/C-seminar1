/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/


//   Задача 19

/*
Console.WriteLine("Введите пятизначное число ");
string a = Console.ReadLine()!;


    if (a.Length == 5)
    {
        if (a[0] == a[4] && a[1] == a[3])
        {
            Console.WriteLine("Данное число является палиндромом ");
        }
        else
        {
            Console.WriteLine("Данное число не является палиндромом ");
        }
    }
    else
    {
        Console.WriteLine("Введено не пятизначное число ");
        return ;
    }
    return ;
*/


//   Задача 21

/*
   //  Вариант 1

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] a = new int[3];
int[] b = new int[3];

a[0] = ReadInt("Введите координату Х точки А: ");
a[1] = ReadInt("Введите координату Y точки А: ");
a[2] = ReadInt("Введите координату Z точки А: ");
b[0] = ReadInt("Введите координату Х точки B: ");
b[1] = ReadInt("Введите координату Y точки B: ");
b[2] = ReadInt("Введите координату Z точки B: ");

double res = Math.Round(Math.Sqrt(Math.Pow(a[0]-b[0], 2) + Math.Pow(a[1]-b[1], 2) + Math.Pow(a[2]-b[2], 2)), 2);
Console.WriteLine("Расстояние между точками = " + res);
*/


/*
   //  Вариант 2

 int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(int[] a, int[] b)
{
    return Math.Round(Math.Sqrt(Math.Pow(a[0]-b[0], 2) + Math.Pow(a[1]-b[1], 2) + Math.Pow(a[2]-b[2], 2)), 2);
}

int[] a = new int[3];
int[] b = new int[3];

a[0] = ReadInt("Введите координату Х точки А: ");
a[1] = ReadInt("Введите координату Y точки А: ");
a[2] = ReadInt("Введите координату Z точки А: ");
b[0] = ReadInt("Введите координату Х точки B: ");
b[1] = ReadInt("Введите координату Y точки B: ");
b[2] = ReadInt("Введите координату Z точки B: ");

double res = Distance(a, b);

Console.WriteLine("Расстояние между точками = " + res);
*/




//   Задача 23


/*
    // Вариант 1

 int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadInt("Введите число N: ");

for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + " , ");
}
*/


// Вариант 2


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void NumPow(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3) + " , ");
    }
}

int num = ReadInt("Введите число N: ");
NumPow(num);
