﻿using System;
using TwoDimensionalArraysLibrary;

namespace TwoDemensionalArrayConsole
{
    class TwoDemensionalArrayConsoleTest
    {
        static void Main(string[] args)
        {
            int[,] array = TwoDimensionalArraysHelper.FillingArray(3, -20, 20);
            Console.WriteLine("Input array: ");

            array = new int[3, 3] { { 3, 1, 6 }, { 2, 14, 5 }, { 3, 2, 9 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"\t{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            //(int minI, int minJ) = TwoDimensionalArraysHelper.FindMinimumIndexInArray(array);
            //(int maxI, int maxJ) = TwoDimensionalArraysHelper.FindMaximumIndexInArray(array);

            //Console.WriteLine($"Minimum value = {TwoDimensionalArraysHelper.FindMinimumInArray(array)}" +
            //    $" | indexed array[{minI},{minJ}]" +
            //    $" | Minimum index value = {TwoDimensionalArraysHelper.FindMinimumInArrayV2(array)}");
            //Console.WriteLine($"Maximum value = {TwoDimensionalArraysHelper.FindMaximumInArray(array)}" +
            //    $" | indexed array[{maxI},{maxJ}]" +
            //    $" | Maximum index value = {TwoDimensionalArraysHelper.FindMaximumInArrayV2(array)}");

            
            Console.WriteLine($"{TwoDimensionalArraysHelper.CounterValueIsLargerNeighbors(array)}");
        }
    }
}
