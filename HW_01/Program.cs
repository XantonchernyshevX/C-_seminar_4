// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32((Console.ReadLine()));

Console.Write("Введите второе число: ");
int b = Convert.ToInt32((Console.ReadLine()));

int exponentiation(int a, int b)
{
    int result = 1;                           // Math.Pow(a, b)
    for (int i = 1; i <= b; i++)
    {
        result = result*a;
    }
    return result;
}
int Exponentiation = exponentiation(a, b);
Console.Write($"Число {a} в степени числа {b}: " + Exponentiation);