/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

i = 1, j = 3 -> Такой элемент есть: 3
i = 4, j = 2 -> такого элемента в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



//     Задача 47

/*
Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

double[,]  array=  GetArray(rows, colums, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int Min, int Max)
{
    double[,] res = new double[m,n];
    
    for (int i=0; i < m; i++)
    {
         for (int j = 0; j < n; j++)
         {
            res[i,j] = new Random().NextDouble() + new Random().Next(Min, Max +1);
         }
    }
    return res;
}


void PrintArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/


//     Задача 50

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[4, 6];
 GetArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");



void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


