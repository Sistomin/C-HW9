// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InputNumbers("Введите m: "); // вызов метода на прием склавиатуры числа веденного пользователем 
int n = InputNumbers("Введите n: "); // вызов метода на прием склавиатуры числа веденного пользователем

int functionAkkerman = Ack(m, n); // вызов метода "Аккермана"

Console.Write($"Функция Аккермана = {functionAkkerman} "); // ввывод в консоль результатов

int Ack(int m, int n)  // Метод "Аккермана" рассчет
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) // метод который принемает введенное с клавиатуры число пользователя
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}