// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int multinumber(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;

}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат произведения цифр от 1 до {number}: " + multinumber(number));
