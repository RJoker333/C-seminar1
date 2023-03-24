/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)

[3, 7.4, 22.3, 2, 78] -> 76
*/

/*
//  Задача 1

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] num = new int[size];
ArrayRandomNum(num);
PrintArray(num);

int count = 0;

for (int a = 0; a < num.Length; a++)
if (num[a] % 2 == 0)
count++;

Console.WriteLine($"Колличество четных чисел в массиве: {count} ");

// ----------------Massive-------------------------------
void ArrayRandomNum(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,999);
    }
}

// ----------------Massive--------------------------------
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/


/*
//  Задача 2


Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] num = new int[size];
ArrayRandomNum(num);
PrintArray(num);
int sum = 0;

for (int b = 0; b < num.Length; b+=2)
{
    sum = sum + num[b];
}

Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {sum}");

// ----------------Massive-------------------------------
void ArrayRandomNum(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1,100);
    }
}

// ----------------Massive--------------------------------
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/


//  Задача 3


Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
double[] num = new double[size];
ArrayRandomNum(num);
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
        {
            max = num[z];
        }
    if (num[z] < min)
        {
            min = num[z];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void ArrayRandomNum(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] num)
{
    Console.Write("[");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


