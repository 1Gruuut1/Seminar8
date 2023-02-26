// Двумерные массивы продолжение.
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

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) &&
       row2 >= 0 && row2 < array.GetLength(0) &&
       row1 != row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else Cobsole.WriteLine("Error!");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a number of the first row for changing: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second row for changing: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, r1, r2);
Show2dArray(newArray);
*/
// Задача 1:
// Задайте двумерный массив и напишите программу, которая заменяет строки на столбцы.
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
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue + 1);   
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReplacementMatrix(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
                
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ReplacementMatrix(myArray);
Show2dArray(myArray);
*/
// Задача 2:
// Из двумерного массива целых чисел удалите наименьшие строку и столбец,
// на пересечении которых расположен наименьший эллимент.
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
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue + 1);   
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] MinNumArray(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] < array[minI,minJ])
            {
                minI = i;
                minJ = j;
            }
    int[] pos = {minI,minJ};
    return pos;
}

int[,] DeletRowColumnMinElement(int[,] array, int[] pos)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0, x = 0; i < array.GetLength(0); i++)
        if(i != pos[0])
        {
            for(int j = 0, y = 0; j < array.GetLength(1); j++)
            {
                if(j != pos[1])
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }
            }
            x++;
        }
    return newArray;
}
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[] pos = MinNumArray(newArray);
int[,] matrix = DeletRowColumnMinElement(newArray, pos);
Show2dArray(matrix);
*/

// Домашнее задание:
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.