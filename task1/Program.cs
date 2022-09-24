// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int CountMultipli(int[] array, int x)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]%x == 0)
        {
            count +=1;
        }
    }return count;
}

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] numbers = new int[10];
FillArray(numbers);
System.Console.Write("[{0}]",string.Join(", ", numbers));
System.Console.WriteLine();
System.Console.WriteLine($"В массиве {CountMultipli(numbers, 2)} чисел кратных {2})");
