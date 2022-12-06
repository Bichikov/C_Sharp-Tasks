﻿// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        } 
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");  
        }
            Console.WriteLine("|");
    }
}

string Number(int[,] matrix, int ax, int bx, int row, int col)
{
    int ay = ax -1;
    int by = bx -1; 
    if (ay <= row && by <= col) 
    {
        return $"Элемент массива найдет и = {matrix[ay,by]}";
    }
return "Такого элемента в массиве нету";
}

Console.Clear();

Console.Write("Введите кол-во строк для массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов для массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rows ,columns ,2, 8);
PrintMatrix(array);

Console.WriteLine("");

Console.Write("Введите индекс по строке: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс по столбцу: ");
int b = Convert.ToInt32(Console.ReadLine());

string number = Number(array,a, b, rows, columns);

Console.Write($"{number}");