// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 0;
int N = 0;
int sum = 0;

int.TryParse(Console.ReadLine(), out M);
int.TryParse(Console.ReadLine(), out N);

string Function(int M, int N)
{
    sum += M;
    if (M == N) return sum.ToString();
    else return (Function(M + 1, N));
}
if (M < N) Console.Write($"Сумма элементов: {Function(M, N)}");
else Console.WriteLine("Нкверный ввод! ");