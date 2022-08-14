// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue) 
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray (int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FindАverageNumber(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        int result = 0;

        for(int j=0; j < array.GetLength(1); j++)
        {
            result = result+ array[i,j];
        }
        result = result / array.GetLength(1);

        Console.WriteLine(result);
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(4, 4, 5, 50);
Show2dArray(myArray);
FindАverageNumber(myArray);