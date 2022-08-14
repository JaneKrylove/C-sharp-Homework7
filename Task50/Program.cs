// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void Show2dArray (int[,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpurt max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray =  CreateRandom2dArray(a, b, min, max);

Console.WriteLine();

Show2dArray(myArray);

Console.WriteLine();

Console.Write("Input row number finding number: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column number finding number: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > myArray.GetLength(0) || j > myArray.GetLength(1)) {
    Console.WriteLine("There is no number under this position");
}
else {
    Console.WriteLine(myArray[i - 1,j - 1]);
}