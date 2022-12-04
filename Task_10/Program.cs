/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999)
    {
        Console.WriteLine("Число НЕ трехзначное!\nВведите трехзначное число: ");
                number = Convert.ToInt32(Console.ReadLine());
    }

int n1 = number % 100;

Console.WriteLine(n1 / 10);