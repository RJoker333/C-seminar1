/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

1, 2, 3

4, 6, 1

2, 1, 6

1 встречается 3 раза

2 встречается 2 раз

3 встречается 1 раз

4 встречается 1 раз

6 встречается 2 раза

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

-------------------Задачи повышенной сложности---------------------
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


//    Задача  54


/*
Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,column, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] rez = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            rez[i,j] = new Random().Next(min, max+1);
        }
    }
    return rez;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}");
        }
        Console.WriteLine();
    }
}


void SortArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j+1; t < array.GetLength(1); t++)
            {
                if (array[i,t]>array[i,j] )
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,t];
                    array[i,t] = temp;
                }
            }
        }
    }
}
*/



//    Задача  57



/*
Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows,column, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] rowArray = GetRovArray(array);
SortArray(rowArray);
Console.WriteLine(String.Join(" ", rowArray));
PrintData(rowArray);


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] rez = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            rez[i,j] = new Random().Next(min, max+1);
        }
    }
    return rez;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}");
        }
        Console.WriteLine();
    }
}


int[] GetRovArray(int[,] InArray)
{
    int[] rez = new int[InArray.GetLength(0)*InArray.GetLength(1)];
    int index =0;
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            rez [index] = InArray[i,j];
            index++; 
        }
    }
    return rez;
}


void SortArray (int[] InArray)
{
    for (int i = 0; i < InArray.Length; i++)
    {
        for (int j = i+1; j < InArray.Length; j++)
        {
                if (InArray[i]>InArray[j])
                 {
                    int p = InArray[i];
                    InArray[i] = InArray[j];
                    InArray[j] = p;
                 }
        }
    }
}

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int N = 1;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i]!=el)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{el} Встречается {N}");
                el = inArray[i];
                N = 1;
            }
        }
        else
        {
            N ++;
        }
    }
    Console.Write($"{el} Встречается {N}");
}
*/





//    Задача  57


Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, column];
int[,] secondArray = new int[rows, column];
int[,] resultArray = new int[rows, column];

FillArrayRandom(array);
PrintArray2(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2(resultArray);


void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

