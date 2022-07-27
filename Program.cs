// В ДВУМЕРНОМ МАССИВЕ УПОРЯДОЧИТЬ ПО УБЫВАНИЮ ЭЛЕМЕНТЫ КАЖДОЙ СТРОКИ

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 101);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortCollectionByRows(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            for (int k = j + 1; k < collection.GetLength(1); k++)
            {
                int temp = 0;
                if (collection[i, j] < collection[i, k])
                {
                    temp = collection[i, j];
                    collection[i, j] = collection[i, k];
                    collection[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Enter number of rows:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns);
ShowArray(myArray);

Console.WriteLine();
SortCollectionByRows(myArray);
ShowArray(myArray);
