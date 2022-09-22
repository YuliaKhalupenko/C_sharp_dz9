// Задайте значения M и N. Напишите программу, которая найдет сумму чисел от M до N.
//M = 1; N = 5. -> 15
//M = 4; N = 8. -> 30


static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
    else return N + SumNumbers(M, N + 1);            // Если M>N
}

Console.Clear();

Console.Write("M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Result, Sum = {SumNumbers(M, N)}");

