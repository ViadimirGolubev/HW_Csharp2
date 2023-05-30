// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число");

// int num=Convert.ToInt32(Console.ReadLine());

// if ((num>99)&&(num<1000));
// {
//    int num3=(num/10)%10; 
//    Console.WriteLine(num3);
// }
// else
// {
//    Console.WriteLine("Недопустимое число");
// }

   



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Недопустимое число");





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());

if (num<1||num>7)
{
   Console.WriteLine("Такого дня недели нет");
}

else if (num==6||num==7)
{
   Console.WriteLine("Выходной"); 
}

else
{
   Console.WriteLine("Будний день"); 
}