// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Task_47()
{
    Console.Write("Введите количество столбцов масcива: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк масcива: ");
    int line = Convert.ToInt32(Console.ReadLine());

    double [,] array = new double [column, line];
    CreateArray(column, line);
    
    double [,] CreateArray(double column, double line)
    {
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < line; j++)
            {
                array [i, j] = Convert.ToDouble(new Random().Next(0, 100)) / 10;
            }
        }
        return array;
    }
    PrintArray(array);
    void PrintArray(double [,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i,j]}\t");
            }
            Console.WriteLine();
        }
    }
} 


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Task_50()
{
    Console.Write("Введите позицию элемента по столбцу: ");
    int columnPosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию элемента по строке: ");
    int linePosition = Convert.ToInt32(Console.ReadLine());

    int column = 5;
    int line = 5;
    CreateArray(column, line);
    int [,] array = CreateArray(column, line);
    PrintArray(array);

    if (linePosition < array.GetLength(0) && columnPosition < array.GetLength(1))
    {
        Console.WriteLine($"Число с индексом y = {columnPosition}; x = {linePosition}: {array[columnPosition, linePosition]}");
    }
    else
    {
        Console.WriteLine($"Индекса y = {columnPosition}; x = {linePosition} - нет");
    }

    int [,] CreateArray(int column, int line)
    {
        int [,] result = new int [column, line];
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < line; j++)
            {
                result [i, j] = new Random().Next(1, 10);
            }
        }
        return result;
    }

    void PrintArray(int [,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i,j]}\t");
            }
            Console.WriteLine();
        }
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void Task_52()
{
    Console.Write("Введите количество столбцов масcива: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк масcива: ");
    int line = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [column, line];

    CreateArray(column, line);
    PrintArray(array);

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i, j]);
        }
        avarage = Math.Round(avarage / column, 2);
        Console.Write(avarage + "; \t");
    }
    Console.WriteLine();

    int [,] CreateArray(int column, int line)
    {
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < line; j++)
            {
                array [i, j] = new Random().Next(0, 10);
            }
        }
        return array;
    }
    void PrintArray(int [,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i,j]}\t");
            }
            Console.WriteLine();
        }
    }
}

Task_47();
// Task_50();
// Task_52();