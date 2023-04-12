
/*
Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/



//   Задача 64

/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNum(1, N));

string PrintNum (int start, int end)
{
    if (start == end) return start.ToString();
    return (end + " " + PrintNum( start, end - 1));
}
*/

//   Задача 66

/*
Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine()!);


///Метод нахождения суммы натуральных элементов в промежутке от M до N
void NumSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);  
    NumSum(M, N, sum);
}

NumSum(M, N, 0);
*/



//   Задача 68


// Console.WriteLine("Введите начальное число m:");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите начальное число n:");
// int n = int.Parse(Console.ReadLine()!);

 int m = InputNumbers("Введите неотрицательное число m: ");
 int n = InputNumbers("Введите неотрицательное число n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}



