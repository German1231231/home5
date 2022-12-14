//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] array = new double[5];
Random rand = new Random();

//Можно написать так:
//int max = int.MinValue;
//int min = int.MaxValue;

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10, 100) + rand.NextDouble();
    array[i] = Math.Round(array[i], 2);
}

//А можно так, не знаю как лучше писать сейчас, для проверки дз
double max = array[0];
double min = array[0];

//Можно foreach
//Можно так же в ответе убрать все дроби, написав тут int i, а не double
foreach(double i in array)
{
    if(i > max)
    {
        max = i;
    }

    else if(i < min)
    {
        min = i;
    }
}

//Можно просто for
/*for(int j = 1; j < array.Length; j++)
{
    if(array[j] > max)
    {
        max = array[j];
    }

    else if(array[j] < min)
    {
        min = array[j];
    }
}*/

double result = max - min;
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.Write($"{max} - {min} = {result}");