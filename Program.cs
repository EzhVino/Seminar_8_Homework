// // В ДВУМЕРНОМ МАССИВЕ УПОРЯДОЧИТЬ ПО УБЫВАНИЮ ЭЛЕМЕНТЫ КАЖДОЙ СТРОКИ

// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 101);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortCollectionByRows(int[,] collection)
// {
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         for (int j = 0; j < collection.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < collection.GetLength(1); k++)
//             {
//                 int temp = 0;
//                 if (collection[i, j] < collection[i, k])
//                 {
//                     temp = collection[i, j];
//                     collection[i, j] = collection[i, k];
//                     collection[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(rows, columns);
// ShowArray(myArray);

// Console.WriteLine();
// SortCollectionByRows(myArray);
// ShowArray(myArray);

// // В ПРЯМОУГОЛЬНОМ ДВУМЕРНОМ МАССИВЕ ВЫВОДИТЬ НОМЕР СТРОКИ С НАИМЕНЬШЕЙ СУММОЙ ЭЛЕМЕНТОВ

// int[,] CreateArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int MinRow(int[,] collection)
// {
//     int minRowSum = 0;
//     int minRowIndex = 0;
//     for (int i = 0,j = 0; j < collection.GetLength(1); j++)
//     {
//          minRowSum = minRowSum + collection[i,j];
//     }
//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < collection.GetLength(1); j++)
//         {
//             sum = sum + collection[i, j];
//         }
//         if (sum < minRowSum)
//         {
//             minRowSum = sum;
//             minRowIndex = i;
//         }
//     }
//     return minRowIndex;
// }

// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a different number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows != columns)
// {
//     int[,] myArray = CreateArray(rows, columns, 1, 100);
//     ShowArray(myArray);
//     Console.WriteLine($"Minimum sum is in the row {(MinRow(myArray) + 1)}");
// }
// else Console.WriteLine("Error. Please enter variable number of rows and columns.");

// // ВЫВЕСТИ ПРОИЗВЕДЕНИЕ ДВУХ МАТРИЦ

// int[,] CreateMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MergeMatrix(int[,] matrixOne, int[,] matrixTwo)
// {
//     int[,] newMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

//     for (int i = 0; i < matrixOne.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixTwo.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrixTwo.GetLength(0); ++k)
//             {
//                 newMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
//             }
//         }
//     }
//     return newMatrix;
// }

// Console.WriteLine("Enter number of rows for matrix 1:");
// int rowsFirst = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns for matrix 1:");
// int columnsFirst = Convert.ToInt32(Console.ReadLine());
// int[,] matrixFirst = CreateMatrix(rowsFirst, columnsFirst, 1, 50);
// ShowMatrix(matrixFirst);

// Console.WriteLine("Enter number of rows for matrix 2:");
// int rowsSecond = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns for matrix 2:");
// int columnsSecond = Convert.ToInt32(Console.ReadLine());
// int[,] matrixSecond = CreateMatrix(rowsSecond, columnsSecond, 1, 60);
// ShowMatrix(matrixSecond);

// Console.WriteLine();

// if (columnsFirst == rowsSecond)
//     ShowMatrix(MergeMatrix(matrixFirst, matrixSecond));
// else
//     Console.WriteLine("Can't multiply matrices. Number of columns in first matrix should be equal to number of rows in second matrix");

// // СФОРМИРОВАТЬ ТРЕХМЕРНЫЙ МАССИВ ИЗ НЕПОВТОРЯЮЩИХСЯ ДВУЗНАЧНЫХ ЧИСЕЛ. ВЫВЕСТИ ПОСТРОЧНО МАССИВ ДОБАВЛЯЯ ИНДЕКСЫ ДЛЯ КАЖДОГО ЭЛЕМЕНТА

// int ReplaceRepeatedNumber(int[,,] array, int number)
// {
//     int newNumber = number;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == number)
//                     number = new Random().Next(10, 100);
//             }
//         }
//     }
//     return newNumber;
// }

// int[,,] Create3DArray(int m, int n, int l)
// {
//     int[,,] collection = new int[m, n, l];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < l; k++)
//             {
//                 int element = new Random().Next(10, 100);
//                 collection[i, j, k] = ReplaceRepeatedNumber(collection, element);

//             }
//         }
//     }
//             return collection;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.WriteLine($"element {i}{j}{k}: {array[i, j, k]} ");
//             }
//         }
//     }
// }

// Console.WriteLine("Enter number of rows:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of layers:");
// int layers = Convert.ToInt32(Console.ReadLine());

// if (rows*columns*layers<100)
// {
//     int[,,] myArray = Create3DArray(rows, columns, layers);
//     Show3DArray(myArray);
// }
// else Console.WriteLine("Incorrect size of the massive");



// ЗАПОЛНИТЕ СПИРАЛЬНО МАССИВ 4 НА 4.

int[,] GetArray(int size)
{
    int[,] newArray = new int[size, size];

    int row = 0;
    int column = 0;
    int finalRow = size - 1;
    int finalcolumn = size - 1;
    int startingRow = 0;
    int startingColumn = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < size * size)
    {
        count++;
        newArray[row, column] = count;

        if (left && top)
        {
            if (column == finalcolumn)
            {
                startingRow++;
                top = true;
                left = false;
                row++;
                continue;
            }
            else
            {
                column++;
                continue;
            }
        }
        if (!left && top)
        {
            if (row == finalRow)
            {
                finalcolumn--;
                top = false;
                left = false;
                column--;
                continue;
            }
            else
            {
                row++;
                continue;
            }
        }
        if (!left && !top)
        {
            if (column == startingColumn)
            {
                finalRow--;
                top = false;
                left = true;
                row--;
                continue;
            }
            else
            {
                column--;
                continue;
            }
        }
        if (left && !top)
        {
            if (row == startingRow)
            {
                startingColumn++;
                top = true;
                left = true;
                column++;
                continue;
            }
            else
            {
                row--;
                continue;
            }
        }
    }
    return newArray;
}


void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write($"Input size of the matrix: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[,] arr = GetArray(userSize);
ShowMatrix(arr);

