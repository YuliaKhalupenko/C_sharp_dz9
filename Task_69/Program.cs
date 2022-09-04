﻿//  Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int a = InputNumbers("Введите A: ");
int b = InputNumbers("Введите B: ");

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int RecPow(int a, int b)
    {
        if (b > 0) return a * RecPow(a, b - 1);
        return 1;
    }

Console.WriteLine(RecPow(a, b));
