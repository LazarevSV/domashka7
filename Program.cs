// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


/*

double[,] CreateRandom2dArray()
{

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());



double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)

        for(int j = 0; j < columns; j++)
    
        array[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 1);
return array;
}


void Show2dArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);


*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

/*
int[,] CreateRandom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine();
}
    Console.WriteLine();
}

void  Findnumber(int[,] array, int m, int n)
{
    if(m <= array.GetLength(0) && n <= array.GetLength(1))
    Console.WriteLine($"Element value: {array[m, n]}");
    else Console.WriteLine("No element this index");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);


Console.Write("Input element index of rows: ");
int RowsUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Input element index of columns: ");
int UserColumns = Convert.ToInt32(Console.ReadLine());
Findnumber(myArray, RowsUser, UserColumns);

*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}




double[] AverageValue(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            average[j] += array[i,j];
        average[j] = average[j] / array.GetLength(0);
    }
    
    return average;
}
void ShowArray(double[] average)
{
    for(int i = 0; i < average.Length; i++)
        Console.Write(average[i] + " ");
    Console.WriteLine();
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] myAverage = AverageValue(myArray);
Console.WriteLine("Arithmetic mean of each column:");

ShowArray(myAverage);