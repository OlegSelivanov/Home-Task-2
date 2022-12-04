/*Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/ 

/*Console.Clear();

int number = new Random().Next(100,1000);

Console.WriteLine($"Сгенерированное число {number}");

int n1 = number / 100;

int n3 = number % 10;

Console.WriteLine(n1 * 10 + n3 * 1);

/* Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1,
 то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

/*Console.Clear();
Console.WriteLine("Введите первое число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = Convert.ToDouble(Console.ReadLine());
if (a % b == 0)
    Console.WriteLine("Первое число кратно второму");
else
    Console.WriteLine($"Не кратно остаток {a % b}");

/* Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/

/*Console.Clear();
Console.WriteLine();
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
*/

/* Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
Console.Clear();
*/

/*Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m || m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
*/

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("end"); // вводит цифры до нуля, псле ввщда 0 выдает энд