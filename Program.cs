// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите кол. строчек");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кол. колонок");
// int colums = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows,colums];

// void GetArrray()
// {
//     Console.WriteLine("Задан массив:");

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,11);
//         }
//     }
// }

// void PrintArray()
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     Console.WriteLine("Получается вот такой массив:");

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i,k] < array[i,k+1])
//                 {
//                     int temp = array[i,k+1];
//                     array[i,k+1] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }   
//     }
// }
// GetArrray();
// PrintArray();
// Console.WriteLine("__________________");
// ChangeArray();
// PrintArray();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите кол. строчек");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кол. колонок");
// int colums = Convert.ToInt32(Console.ReadLine());
    
// int [,] array = new int [rows,colums];

// GetArrray();
// PrintArray();
// NumberRowMinSumElements();

// void GetArrray()
// {
//     Console.WriteLine("Задан массив:");

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,20);
//         }
//     }
// }

// void PrintArray()
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void NumberRowMinSumElements()
// {
//     int minLine = 0;
//     int minSumLine = 0;
//     int sumLine = 0;

//     for (int i = 0; i < array.GetLength(1); i++) 
//     {
//         minLine += array[0, i];
//     }
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
//                         if (sumLine < minLine)
//                         {
//                             minLine = sumLine;
//                             minSumLine = i;
//                         }
//                         sumLine = 0;
//             }
//             Console.Write($"Строка c наименьшей суммой элементов: {minSumLine + 1}");
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите кол. строчек");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кол. колонок");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, colums];
// int[,] secondArray = new int[rows, colums];
// int[,] resultArray = new int[rows, colums];

// GetArrray(array);
// PrintArray(array);

// Console.WriteLine();

// GetArrray(secondArray);
// PrintArray(secondArray);

// Console.WriteLine();

// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine("Нельзя перемножить");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array[i, j] * secondArray[k, j];
//         }
//     }
// }
// Console.WriteLine("Результирующая матрица будет:");
// PrintArray(resultArray);

// void GetArrray(int[,] array)
// {
//     Console.WriteLine("Задан массив:");

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(2,5);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array3D = new int[2, 2, 2];

// GetArrray(array3D);
// PrintArray(array3D);

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// void GetArrray(int[,,] array)
// {
//     int count = 10;
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 array3D[i, j, k] = new Random().Next(10, 40);
//                 array3D[i, j, k] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     array[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray();

// void PrintArray()
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }