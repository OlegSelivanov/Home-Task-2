/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int NumberDey = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int NumberDey)  
{
  if (NumberDey == 6 || NumberDey == 7) 
  
    Console.WriteLine("Это выходной день");
  
  else if (NumberDey < 1 || NumberDey > 7) 
  
    Console.WriteLine("Это не день недели");
  
  else 
    Console.WriteLine("Это не выходной день");
}
CheckingTheDayOfTheWeek(NumberDey);