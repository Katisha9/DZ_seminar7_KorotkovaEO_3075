// Знакомство с языками программирования (семинары)
// Урок 7. Как не нужно писать код. Часть 1
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -100, 100);
PrintArray(array);
*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2
/*
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);

Console.WriteLine("Введите номер строки (начиная с 0) - i: ");
int row = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца (начиная с 0)- j: ");
int column = int.Parse(Console.ReadLine()!);

//if (( row > 5) || (column > 5))
if ((row >= array.GetLength(0)) && (column >= array.GetLength(1)))
{
     Console.WriteLine("Такого элемента в массиве нет");
}

else {
     Console.WriteLine($"Значение элемента на позиции [{row}; {column}] равно {array[row, column]} ");
    }
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] sredArefm = new double [array.GetLength(1)];

for (int j = 0; j < array.GetLength(1); j++)
{
    double summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ += array[i, j];
        sredArefm[j] = summ / array.GetLength(0);
    }
}

Console.WriteLine($"Среднее арифметическое каждого столбца {String.Join("; ", sredArefm)}");


// методы для создания и заполнения массивов для дз
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j=0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j=0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
    }
}
