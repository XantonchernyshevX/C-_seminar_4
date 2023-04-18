// // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Console.Write("Введите число: ");
// string s = Console.ReadLine();
// int result = s.Length;
// Console.WriteLine("Количество цифр в числе: " + result);

// // Method 01
int Input()
{
Console.Write("Введите число: ");
string s = Console.ReadLine();
return s.Length;
}
int str = Input();
Console.WriteLine("Количество цифр в числе: " + str);

// Method 02 - не работает с числами более 10 знаков
// Console.Write("Введите число: ");
// int Get(int num)
// {
//     int count = 1;
//     while (num > 9)
//     {
//         // num=num/10;
//         num /= 10;
//         count++;
//     }
//     return count;
// }
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Количество цифр в числе: " + Get(a));