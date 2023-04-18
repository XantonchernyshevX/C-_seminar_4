// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] array = new int[8];

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 99);
        index++;        
    }
}
FillArray(array);
Console.WriteLine(String.Join(", ", array));
