/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int NumberDey = Convert.ToInt32(Console.ReadLine());

while (NumberDey < 1 || NumberDey > 7)
    {
        Console.WriteLine("Цифра не обозначает день недели!\nВведите цифру, обозначающую день недели: ");
                NumberDey = Convert.ToInt32(Console.ReadLine());
    }

void CheckingTheDayOfTheWeek (int NumberDey)  
{
  if (NumberDey == 6 || NumberDey == 7) 
  
    Console.WriteLine("Да, это выходной день!");
  
  else 
    Console.WriteLine("Нет, это не выходной день :(");
}
CheckingTheDayOfTheWeek(NumberDey);