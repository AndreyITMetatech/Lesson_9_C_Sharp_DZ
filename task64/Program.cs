// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

int M = 0;
int N = 0;

int.TryParse(Console.ReadLine(), out M);
int.TryParse(Console.ReadLine(), out N);

string Function(int M, int N)
{
    if (M == N) return M.ToString();
    else return (M + " " + Function(M + 1, N));
}
if (M < N) Console.Write(Function(M, N));
else Console.WriteLine("Неверный ввод! ");