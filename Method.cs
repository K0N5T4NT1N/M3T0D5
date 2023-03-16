namespace MyM3th0d5
{
#nullable disable
    public class M3th0d5
    {
        /*========================= методы ВВОДА пользователя =========================*/

        int InputUser(string message)
        {
            Console.WriteLine(message);
            string ReadVoid = Console.ReadLine();
            int result = int.Parse(ReadVoid);
            return result;
        }

        double InputUserDouble(string message)
        {
            Console.Write(message);
            string ReadVoid = Console.ReadLine();
            var result = Convert.ToDouble(ReadVoid);
            return result;
        }

        int[,,] Matrix3D(int valueX, int valueY, int valueZ, int[] fill)
        {
            int[,,] matrix = new int[valueX, valueY, valueZ];

            for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2);)
            {
                for (int x = 0; x < matrix.GetLength(0); x++)
                {
                    for (int y = 0; y < matrix.GetLength(1); y++)
                    {
                        for (int z = 0; z < matrix.GetLength(2); z++)
                        {
                            matrix[x, y, z] = fill[i];
                            i++;
                        }

                    }
                }
            }
            return matrix;
        }

        /*====================== методы ЗАДАНИЯ массивов и проч. ======================*/

        int[] GenerateArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        double[] RandomDoubleArray(int length, int minValue, int maxValue)
        {
            double[] doubles = new double[length];
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                doubles[i] = Convert.ToDouble(random.Next(-100, 100) / 10.0);
            }
            return doubles;
        }

        int[,] GetMatrix(int rows, int columns, int min, int max) //двумерный массив размером m×n, заполненный случайными целыми числами.
        {
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int l = 0; l < columns; l++)
                {
                    matrix[i, l] = new Random().Next(min, max + 1);
                }
            }
            return matrix;
        }

        double[,] GetMatrixDouble(int rows, int columns, int min, int max) //двумерный массив размером m×n, заполненный случайными вещественными числами.
        {
            double[,] matrix = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int l = 0; l < columns; l++)
                {
                    matrix[i, l] = new Random().Next(min, max + 1) + new Random().NextDouble();
                }
            }
            return matrix;
        }

        /*============================= методы ВЫЧИСЛЕНИЯ =============================*/

        bool isEven(int i, int l)
        {
            return i % 2 == 0 && l % 2 == 0;
        }
        int CountEvenNum(int[] array)
        {
            int count = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            return count;
        }

        void CheckMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (isEven(i, l))
                    {
                        matrix[i, l] *= matrix[i, l];
                    }
                }

            }
        }

        bool MajorDiag(int i, int l)
        {
            return i == l;
        }

        int SumNumMatrix(int[,] matrix)
        {
            int Sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (MajorDiag(i, l))
                    {
                        Sum += matrix[i, l];
                    }
                }
            }
            return Sum;
        }

        int CountOddIndex(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i = i + 2)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        double DifferenceMinMax(double[] array)
        {
            double min = array[0];
            double max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            return max - min;
        }

        int CountIndexPositiv(int[] array)
        {
            int count = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) count++;
            }
            return count;
        }

        void Fibonacci(int numberN)
        {
            long temp = 0;
            long fibonacci1 = 1;
            long fibonacci2 = 1;
            if (numberN == 0)
            {
                Console.Write(temp);
            }
            if (numberN == 1)
            {
                Console.Write($"{temp} {fibonacci1}");
            }
            if (numberN == 2)
            {
                Console.Write($"{temp} {fibonacci1} {fibonacci2}");
            }
            else
            {
                Console.Write($"{temp} {fibonacci1} {fibonacci2}");
                for (var i = 2; i < numberN; i++)
                {
                    temp = fibonacci1 + fibonacci2;
                    fibonacci2 = fibonacci1;
                    fibonacci1 = temp;
                    Console.Write($" {fibonacci1}");
                }
            }
        }

        double[] AverageArray(int[,] matrix)
        {
            double[] result = new double[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double temp = 0;
                for (int l = 0; l < matrix.GetLength(0); l++)
                {
                    temp += matrix[l, i];
                }
                result[i] = temp / matrix.GetLength(0);
            }
            return result;
        }

        int[,] SpiralArray(int perimetr, int filling)
        {
            int rows = perimetr;
            int columns = perimetr;
            int i = 0;
            int j = 0;
            int[,] matrix = new int[rows, columns];
            while (filling <= matrix.GetLength(0) * matrix.GetLength(1))
            {
                matrix[i, j] = filling;
                if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= matrix.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > matrix.GetLength(1) - 1)
                    j--;
                else
                    i--;
                filling++;
            }
            return matrix;
        }

        void FindValue(int[,] matrix, int i, int l)
        {
            if (i < matrix.GetLength(0) && l < matrix.GetLength(1))
            {
                Console.WriteLine($"{matrix[i, l]} -> число найдено!");
            }
            else
            {
                Console.WriteLine($"{i}{l} -> числа с данными индексами в массиве нет");
            }
        }

        void DescendingSortOrder(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    for (int j = l + 1; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, l] < matrix[i, j])
                        {
                            int temp = matrix[i, l];
                            matrix[i, l] = matrix[i, j];
                            matrix[i, j] = temp;
                        }
                    }
                }
            }
        }

        void MinSumInRows(int[,] matrix)
        {
            int? minSum = null;
            int indexMinSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sumRow = 0;
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    sumRow += matrix[i, l];
                }
                if (i == 0)
                {
                    minSum = sumRow;
                    indexMinSum = i + 1;
                }
                else if (sumRow < minSum)
                {
                    minSum = sumRow;
                    indexMinSum = i + 1;
                }
            }
            Console.WriteLine($"Cтрока с наименьшей суммой элементов -> {indexMinSum}");
        }

        int[,] MultiplexMatrix(int[,] first, int[,] second)
        {
            int[,] multiMatrix = new int[first.GetLength(0), second.GetLength(1)];

            for (int i = 0; i < first.GetLength(0); i++)
            {
                for (int l = 0; l < second.GetLength(1); l++)
                {
                    for (int k = 0; k < second.GetLength(0); k++)
                    {
                        multiMatrix[i, l] += first[i, k] * second[k, l];
                    }
                }
            }
            return multiMatrix;
        }

        int[] GetShuffleArray()
        {
            int[] array = new int[90];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 10;
            }

            Random fill = new Random();

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int k = fill.Next(i + 1);

                int temp = array[k];
                array[k] = array[i];
                array[i] = temp;
            }
            return array;
        }

        /*======================= методы ВЫВОДА массивов и проч. ======================*/

        void OutputArray(int[] array)
        {
            Console.Write("[");
            for (var i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.Write($"{array[array.Length - 1]}");
            Console.Write("]");
        }

        void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write(matrix[i, l] + " ");
                }
                Console.WriteLine();
            }
        }

        void PrintDouble(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write($"{Math.Round(matrix[i, l], 2)} ");
                }
                Console.WriteLine();
            }
        }

        void PrintMatrix3D(int[,,] matrix)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    for (int z = 0; z < matrix.GetLength(2); z++)
                    {
                        Console.Write($"{matrix[x, y, z]} -> ({x}, {y}, {z}) ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}