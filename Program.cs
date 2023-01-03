// Урок 6. Одномерные массивы. Продолжение

// Задача 41: Пользователь вводит с клавиатуры 
// M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int count1 = 0;
// int count2 = 8;
// for (int i = 1; i <= count2; i++)
// {
//    Console.WriteLine("Введите "+i+" число");
//    int num = Convert.ToInt32(Console.ReadLine());
//     if (num>0)
//     {
//         count1++;
//     }
// }
// Console.WriteLine(count1 + " - чисел больше 0 ввёл пользователь");


// ------------------------------------------------------
// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble (Console.ReadLine());
double x = 0;
double y = 0;
if (k1==k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    x=(b1 - b2)/(k2 - k1);
    y = k2 * x + b2;
}

Console.WriteLine ("Точка пересечения двух прямых x= "+x+"; y= "+y);
