﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = InputNumbers("Введите n: "); // вызов метода на прием числа с клавиатуры, присваеваем числу n
int count = 2; // объявляем переменную присваеваем значение равное 2
PrintNumber(n, count); // вызов рекурсивного метода вывода в консоль натуральных числ в промежутке от N до 1
Console.Write(1); // вывод в консоль последнего значения равного 1

void PrintNumber(int n, int count) // рекурсивный метод для вывода значений в консоль
{
  if (count > n) return;
  PrintNumber(n, count + 1); // вызов метода в самом себе (рекурсия)
  Console.Write(count + ", ");
}

int InputNumbers(string input) // метод который принемает введенное с клавиатуры число пользователя
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}