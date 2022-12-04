/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

** НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК **

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
    }
else if (number >= 100 || number <= 999)
    {
        int n3 = number % 10;
        Console.WriteLine( n3 );
    }
/*else if (number >= 1000)
{
        int n3 = number % 10;
        Console.WriteLine( n3 );
    }*/