/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

 

double[,] CreateRandom2dArrayDouble(int rows, int colums, int minValue, int maxValue) // рандомное заполнение двумерного массива вещественными числами
{
    double[,] newArray = new double[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }

    return newArray;
}
void Show2dArrayDouble (double[,] array) // вывод двумерного массива
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число для рандома: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число для рандома: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArrayDouble(rows, colums, minValue, maxValue);
Show2dArrayDouble(array); 




/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

 
void FindElement(int[,] array, int posRows, int posColums)
{
    if (posRows < array.GetLength(0) && posColums < array.GetLength(1))
        Console.Write(array[posRows, posColums]);
    else Console.Write("Такого числа нет");
}


int[,] array = new int[,]
{
    {56, 43, 23, 74},
    {34, 23, 12, 23},
    {56, 52, 78, 12},
    {19, 00, 73, 43}
};

Console.Write("Введите строку: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int colums = Convert.ToInt32(Console.ReadLine());

FindElement(array, rows, colums);

 
/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
void SumColumsArray(int[,] array)
{
    double sum = 0;
    int j = 0;
    while (j < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        sum /= array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} = {sum}");
        sum = 0;
        j++;
    }
}

int[,] array = new int[,]
{
    {1, 43, 23, 74},
    {5, 23, 12, 23},
    {8, 52, 78, 12}
};

SumColumsArray(array);






