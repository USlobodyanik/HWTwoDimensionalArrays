using System;

namespace TwoDimensionalArraysLibrary
{
    public class TwoDimensionalArraysHelper
    {
        public static int[,] FillingArray(int size = 4, int startRandomNumber = -20, int lastRandomNumber = 20)
        {

            int[,] array = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(startRandomNumber, lastRandomNumber);
                }
            }

            return array;
        }

        public static int FindMinimumInArray(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new Exception("Array is empty or Null");
            }

            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }

            return min;
        }

        public static int FindMinimumInArrayV2(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new Exception("Array is empty or Null");
            }

            (int minI, int minJ) = FindMinimumIndexInArray(array);

            return array[minI, minJ];
        }

        public static int FindMaximumInArray(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new Exception("Array is empty or Null");
            }

            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        public static int FindMaximumInArrayV2(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new Exception("Array is empty or Null");
            }

            (int maxI, int maxJ) = FindMaximumIndexInArray(array);

            return array[maxI, maxJ];
        }

        public static (int, int) FindMinimumIndexInArray(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new Exception("Array is empty or Null");
            }

            int minI = 0;
            int minj = 0;
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        minI = i;
                        minj = j;
                    }
                }
            }

            return (minI, minj);
        }

        public static (int, int) FindMaximumIndexInArray(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new Exception("Array is empty or Null");
            }

            int maxI = 0;
            int maxJ = 0;
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            return (maxI, maxJ);
        }

        public static int CounterValueIsLargerNeighbors(int[,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new Exception("Array is empty or Null");
            }

            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        if (array[i, j] > array[i + 1, j] &&
                            array[i, j] > array[i, j + 1])
                        {
                            count++;
                        }
                    }
                    else if (i == array.GetLength(0) - 1 && j == array.GetLength(1) - 1)
                    {
                        if (array[i, j] > array[i - 1, j] &&
                            array[i, j] > array[i, j - 1])
                        {
                            count++;
                        }
                    }

                    if (i == 0 && j > 0 && j < array.GetLength(1) - 1)
                    {
                        if (array[i, j] > array[i + 1, j] &&
                            array[i, j] > array[i, j - 1] &&
                            array[i, j] > array[i, j + 1])
                        {
                            count++;
                        }
                    }
                    else if (i == 0 && j == array.GetLength(1) - 1)
                    {
                        if (array[i, j] > array[i + 1, j] &&
                            array[i, j] > array[i, j - 1])
                        {
                            count++;
                        }
                    }

                    if (j == 0 && i > 0 && i < array.GetLength(0) - 1)
                    {
                        if (array[i, j] > array[i, j + 1] &&
                            array[i, j] > array[i + 1, j] &&
                            array[i, j] > array[i - 1, j])
                        {
                            count++;
                        }
                    }
                    else if (j == 0 && i == array.GetLength(0) - 1)
                    {
                        if (array[i, j] > array[i, j + 1] &&
                            array[i, j] > array[i - 1, j])
                        {
                            count++;
                        }
                    }

                    if (i > 0 && j > 0 && i < array.GetLength(0) - 1 && j < array.GetLength(1) - 1)
                    {
                        if (array[i, j] > array[i - 1, j] &&
                            array[i, j] > array[i + 1, j] &&
                            array[i, j] > array[i, j - 1] &&
                            array[i, j] > array[i, j + 1])
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
