// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateRandom2dArray (int rows, int columns)

{
    double [,] new2dArray = new double [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)

        new2dArray[i,j] = new Random().Next(1, 100);

        return new2dArray;
}

void ShowArray(double[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(a,b);
ShowArray(myArray); 