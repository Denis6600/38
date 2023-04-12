//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int[] FillArray(int lenght, int minValue, int maxValue)
{
    int[] result = new int[lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
        result[i] = rand.Next(minValue, maxValue + 1);
    return result;
}

int GetMin(int[] array)
{
    int min = 0;

    for (int i = 0; i < array.Length; i++)
    {
        min = array [1];
        if (array[i] < min)
        {
            min = array[i];
        }
    }




    return (min);
}

int GetMax(int[] array)
{
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }




    return (max);
}


int[] array = FillArray(5, 1, 9);
int min = GetMin(array);
int max = GetMax(array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"разница {max - min}");