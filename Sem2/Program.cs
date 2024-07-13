// Методы-функции
// вывод число в квадрате

// int Pow (int n)
// {
//     return n * n;
// }
// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Pow(a));


// Напишите программу, которая принимает на вход трёхзначное
// число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num <1000)
//     {
//         return true;
//     }
//     return false;
// }

// void DeleteSeconddigit(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         System.Console.WriteLine(ed + sot * 10);
//     }
//      else
//  {
//     System.Console.WriteLine("You input not three-digit number");
//  }
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// DeleteSeconddigit(a);


// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num <1000)
//     {
//         return true;
//     }
//     return false;
// }

// void SecondToThirdPower(int num)
// {
//     if(IsThreeDigit(num)) //456
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         System.Console.WriteLine(Math.Pow(dec, ed));
//     }
//     else
//  {
//     System.Console.WriteLine("You input not three-digit number");
//  }
// }
// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// SecondToThirdPower(a);


// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// System.Console.WriteLine(new Random().Next(1,30)); randomaizer


// bool multiplicity (int x, int y)
// {
//     if (x % y == 0)
//     {
//         return true;
//     }
//     return false;
// }

// void Result(int x, int y)
// {
//     if(multiplicity (x, y)) 
//     {
//         System.Console.WriteLine("да");
//     }
//     else
//     {
//         System.Console.WriteLine($"нет, {x % y}");
//     }
// }

// Console.WriteLine("Input first number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Result (x, y);



// ИЛИ 
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите два числа через пробел:");
//         string[] inputs = Console.ReadLine().Split(' ');
//         int firstNumber = Convert.ToInt32(inputs[0]);
//         int secondNumber = Convert.ToInt32(inputs[1]);

//         if (firstNumber % secondNumber == 0)
//         {
//             Console.WriteLine("да");
//         }
//         else
//         {
//             Console.WriteLine($"нет, {firstNumber % secondNumber}");
//         }
//     }
// }
