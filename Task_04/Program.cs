// int[] Random(int number)
// {
//     int[] result = new int[number];
//     for (int y = 0; y < number; y++)
//         result[y] = (new Random().Next(0, 2));
//     return result;
// }
// Console.Write("Введите количество цифр: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine(String.Join(", ", Random(number)));

// void FillArray(int[] RandomArray)
// {
//     int Length = RandomArray.Length;
//     int index = 0;
//     while(index < Length)
//     {
//         RandomArray[index] = new Random().Next(0 ,2);
//         index++;
//     }
// }
// void PrintArray(int[] ArrayDigit)
// {
//     int count = ArrayDigit.Length;
//     int position = 0;
//     while(count < Length)
//     {
//         System.Console.WriteLine(count[position]);
//         index++;
//     }
// }
// int[] array = new int[10];


// int a = 3;
// int b = 4;
// int result = a*b;
// System.Console.WriteLine(result);


void Sum(int x, int y)
{
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int result = x*y;
    Console.WriteLine($"{result}");
}
 
Sum(x, y);    // 10 + 15 = 25

