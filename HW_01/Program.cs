// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

double exponentiation(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}
double expo = exponentiation(a, b);
Console.Write($"Число {a} в степени числа {b}: ");
Console.WriteLine(expo);