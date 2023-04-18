// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits(int number)
{
    int count = Convert.ToString(number).Length;
    int result = 0;
    int position = 0;

    for (int i = 0; i < count; i++)
    {
       position = number % 10;
       result += position;
       number /= 10; 
    }
    return result;
}
int sumdigits = sumDigits(number);
Console.Write($"Сумма цифр в числе {number}: " + sumdigits);