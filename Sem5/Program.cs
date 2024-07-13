// Создание и выведение значений рандомного двумерного массива

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "  ", ConsoleColor.Green);
        }
        System.Console.WriteLine();
    } 
}
PrintMatrix(CreateRandomMatrix(5, 6, 0, 9));
