/*

--------------------------------------------------------------------------------ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ---------------------------------------------------------

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
*/



//  Задача 25


  // Вариант 1

/*
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
int c = 1;


while (B!=0)
{
    c = c * A;
    B = B - 1;
}

Console.WriteLine($"Число А в натуральной степени В: {c}");
*/


   //  Вариант 2


Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");

int Pow(int n, int st)
{
    if (B == 0) return 1;
    int rez = n;
    for (int i = 2; i <= st; i++)
    {
        rez *= n;
    }
    return rez;

}


//  Задача 27

/*
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе А: {GetSum(A)}");

// --------------------------------------Metod------------------------------------------

int GetSum(int n)
{
    int sum =0;
    while (n>=1)
    {
        sum= sum + n%10;
        n=(n-n%10)/10;
    }
    return sum;
}
*/



//  Задача 29

/*
//Console.WriteLine("Введите размерность массива: ");
int n = 8;
int[] massive = OneMass(n);
Console.WriteLine($"Массив из 8 элементов: [{String.Join("; " , massive)}]");

int[]  OneMass(int a)
{
    int[] Rez = new int[a];
    for (int i = 0; i < a; i++)
    {
        Rez[i]= new Random().Next(3);
    }
    return Rez;
}
*/




