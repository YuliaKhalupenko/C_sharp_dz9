// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> 1, 2, 3, 4, 5
//M = 4; N = 8. -> 4, 6, 7, 8


 void Recur(int m, int n)
        {
            if (m > n) return;
            {
                Recur(m, n - 1);
                Console.Write($"{n}, ");
            }
        }

Console.Clear();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
Recur(m, n);

