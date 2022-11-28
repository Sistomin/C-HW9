// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputNumbers("Введите m: "); // вызов метода на прием числа с клавиатуры, присваеваем числу m
int n = InputNumbers("Введите n: "); // вызов метода на прием числа с клавиатуры, присваеваем числу n
int temp = m; // объявляем переменную "временную" присмаеваем значение m

if (m > n) // проверка m > n, если да то присваеваем m = n и n = temp
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0); // вызов метода рассчета и вывода в консоль суммы чисел в промежутке от M до N

void PrintSumm(int m, int n, int summ) // Метод рассчета и вывода в консоль суммы чисел в промежутке от M до N
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}
 
int InputNumbers(string input) // метод который принемает введенное с клавиатуры число пользователя
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
