//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void ArrayRand(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Сумма --> {count}");
}

int[] arr = new int[5];
ArrayRand(arr);
Console.Write("[{0}]", string.Join(", ", arr));