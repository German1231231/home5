//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void SumArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }   

    int sum = 0;

    for(int j = 1; j < array.Length; j+=2)
    {
        sum = sum + array[j];
    }
    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");
}

int[] arr = new int[7];
SumArray(arr);
Console.WriteLine("[{0}]", string.Join(", ", arr));