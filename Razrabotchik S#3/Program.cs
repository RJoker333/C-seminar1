﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/




//  Задача 10


    // Вариант 1

/*
    Console.WriteLine("Введите трехзначное число ");
    int n = int.Parse(Console.ReadLine()!);
       int Sr = ( n %100 - n %10)/10;
       System.Console.WriteLine($"Вторая цифра числа {Sr} ");
*/


    // Вариант 2
           // Добавили условие разбора только 3-х значного числа, остальные просто выводятся

/*
    Console.WriteLine("Введите трехзначное число ");
    int n = int.Parse(Console.ReadLine()!);
        if (n >= 100 && n < 1000)
        {
           int Sr = ( n %100 - n %10)/10;
           System.Console.WriteLine($"Вторая цифра числа {Sr} ");  
        }
*/





//  Задача 13

/*
System.Console.WriteLine("Введите число ");
String? stroka = Console.ReadLine();
if (stroka!.Length > 2)
{
    System.Console.WriteLine(stroka[2]);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число ");
}
*/






//  Задача 15

System.Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
if (n > 5 && n < 8)
{
   System.Console.WriteLine("Да ");  
}
else
{
   System.Console.WriteLine("Нет ");  
}





