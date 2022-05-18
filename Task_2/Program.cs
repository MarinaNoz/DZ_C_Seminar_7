/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
например, задан массив: 1 4 7 2
5 9 2 3 
8 4 2 4
17- > такого числа в массиве нет */

Console.Write("Введите количество строк ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[line,column];
FillArray(matrix);
PrintArray(matrix);
Console.Write("Введите позицию элемента ");
int position = Convert.ToInt32(Console.ReadLine());
int row = position / 10;
int col = position % 10;
if (row > matrix.GetLength(0) || col > matrix.GetLength(1))
{
    Console.WriteLine("В массиве нет такой позиции");
}
else
{
    Console.Write($"Значение элемента {position}: {matrix [row - 1, col - 1]}");
}
void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); 
        }
    }
}
void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}




