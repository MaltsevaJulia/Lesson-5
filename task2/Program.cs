// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array, int size)
{
    for(int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

int DataEntry(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfOddElements(int[] array)
{
    int result = 0;
    for(int i = 1; i<array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
}

int size = DataEntry("Введите размер массива ");
int[] numbers = new int[size];
FillArray(numbers, size);
System.Console.Write("[{0}]", string.Join(", ", numbers));
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных элементов массива равна {SumOfOddElements(numbers)}");
