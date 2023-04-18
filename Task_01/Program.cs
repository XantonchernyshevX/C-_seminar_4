// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int Summary(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        // result = result + i;
        result += i;
    }
    return result;
}
Console.WriteLine($"Сумма всех чисел от 1 до {number}: " + Summary(number));

