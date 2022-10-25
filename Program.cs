// // Найти произведение двух матриц

// int[,] CreateMatrix(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             product[i, j] = matrix1[i, j] * matrix2[i, j];
//         }
//     }
//     return product;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 3;
// int col = 5;

// int[,] matrix1 = CreateMatrix(row, col, 1, 10);
// int[,] matrix2 = CreateMatrix(row, col, 10, 20);
// int[,] product = MultiplyMatrix(matrix1, matrix2);
// PrintMatrix(matrix1);
// System.Console.WriteLine("-------");
// PrintMatrix(matrix2);
// System.Console.WriteLine("-------");
// PrintMatrix(product);




// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// int[,] GetMatrix(int raw, int col, int min, int max)
// {
//     int[,] matrix = new int[raw, col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}  ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[] GetNumsMinRawColumn(int[,] array)
// {
//     int[] numbers = new int[] { 0, 0 };
//     int minNumber = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < minNumber)
//             {
//                 minNumber = array[i, j];
//                 numbers[0] = i;
//                 numbers[1] = j;
//             }
//         }
//     }
//     return numbers;
// }

// int[,] RemoteRawColumn(int[,] matrix, int[] array)
// {
//     int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
//     for (int i = 0; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             if (i < array[0]) matrix2[i, j] = matrix[i, j];
//             else matrix2[i, j] = matrix[i + 1, j];
//         }
//     }
//     int[,] resultMatrix = new int[matrix2.GetLength(0), matrix2.GetLength(1) - 1];
//     {
//         for (int i = 0; i < resultMatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < resultMatrix.GetLength(1); j++)
//             {
//                 if (j < array[1]) resultMatrix[i, j] = matrix2[i, j];
//                 else resultMatrix[i, j] = matrix2[i, j + 1];
//             }
//         }
//     }
//     return resultMatrix;
// }

// int raw = 7;
// int col = 8;
// int min = 1;
// int max = 100;

// int[,] matrix = GetMatrix(raw, col, min, max);
// PrintArray(matrix);
// int[] minPosition = GetNumsMinRawColumn(matrix);
// int[,] matrixWithoutRawCol = RemoteRawColumn(matrix, minPosition);
// PrintArray(matrixWithoutRawCol);


// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// Console.WriteLine($"Введите размер массива X x Y x Z: ");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }


// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
// Console.Write("Введите количество строк : ");
// int n = int.Parse(Console.ReadLine());
           
            
//     int[][] triangle = new int[n][];
//     triangle[0] = new int[] { 1 };
 
//     for (int i = 1; i < triangle.Length; i++)
//     {
//         triangle[i] = new int[i + 1];  
//         for (int j = 0; j <= i; j++)
//         {
//             if (j == 0 || j == i)
//                 triangle[i][j] = 1;
//             else
//             {
//                 triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
//             }
//         }
//     }
 
//     for (int i = 0; i < triangle.Length; i++)
//     {
//         for (int j = 0; j < triangle[i].Length; j++)
//         {
//             Console.Write("{0,-3} ", triangle[i][j]);
//         }
//         Console.WriteLine();
//     }
 
//     Console.ReadKey();
