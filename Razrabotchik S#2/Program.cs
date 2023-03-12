// Решить 4 задачи и написать код

/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */



// Задача 2

/*
  // Вариант 1

 Console.Write("Введите число ");
 int chislo1 = int.Parse(Console.ReadLine()!);
 int chislo2 = int.Parse(Console.ReadLine()!);
 int max = 0 ;
 int min = 0 ;
     if (chislo1 > chislo2) 
        {System.Console.WriteLine(max = chislo1 );
         System.Console.WriteLine(min = chislo2  );}
     else 
         if (chislo2 > chislo1) 
            {System.Console.WriteLine(max = chislo2  );
             System.Console.WriteLine(min = chislo1  );}
*/

/*
    // Вариант 2

 Console.Write("Введите число ");
 int chislo1 = int.Parse(Console.ReadLine()!);
 int chislo2 = int.Parse(Console.ReadLine()!);
 int max, min = 0 ;
     if (chislo1 > chislo2) 
        {System.Console.WriteLine($"Максимальное число: {max = chislo1}" );
         System.Console.WriteLine($"Минимальное число: {min = chislo2}"  );}
     else 
         if (chislo2 > chislo1) 
            {System.Console.WriteLine($"Максимальное число: {max = chislo2}"  );
             System.Console.WriteLine($"Минимальное число: {min = chislo1}"  );}
*/







// Задача 4


   // Вариант 1

   Console.Write("Введите число ");
   int chislo1 = int.Parse(Console.ReadLine()!);
   int chislo2 = int.Parse(Console.ReadLine()!);
   int chislo3 = int.Parse(Console.ReadLine()!);
   int max = 0 ;
    if (chislo1 > chislo2 & chislo1 > chislo3) 
       {System.Console.WriteLine(max = chislo1 );}
    else
       {
          if (chislo2 > chislo1 & chislo2 > chislo3)
             {System.Console.WriteLine(max = chislo2 );}
          else
             {
                if (chislo3 > chislo1 & chislo3 > chislo2)
                   {System.Console.WriteLine(max = chislo3 );} 
             }
       }