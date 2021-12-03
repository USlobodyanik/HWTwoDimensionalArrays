using NUnit.Framework;
using System;
using TwoDimensionalArraysLibrary;

namespace HWTwoDimensionalArrays_UnitTests
{
    public class TwoDimensionalArraysTest
    {
        [TestCase(null)]
        public void FindMinimumInArray_WhenArrayNull_ShouldException(int[,] array)
        {
            try
            {
                TwoDimensionalArraysHelper.FindMinimumInArray(array);
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Array is empty or Null", ex.Message);
            }
        }

        [TestCaseSource(nameof(MinValueCases))]
        public void FindMinimumInArray_WhenFilledArrayPassed_ShouldMinValue
            (int[,] array, int expected)
        {
            int result = TwoDimensionalArraysHelper.FindMinimumInArray(array);

            Assert.AreEqual(expected, result);
        }

        static readonly object[] MinValueCases =
        {
            new object[]
            {
                new int[,]{ {-5,0,1}, {2,4,6}, {10,-1,-2} }, -5
            },
            new object[]
            {
                new int[,]{ {-5,0,1}, {2,4,-6}, {10,-1,-2} }, -6
            },
            new object[]
            {
                new int[,]{ {-5,0,1}, {2,4,-6}, {-10,-1,-2} }, -10
            },
        };

        [TestCaseSource(nameof(MaxValueCases))]
        public void FindMaximumInArray_WhenFilledArrayPassed_ShouldMaxValue
            (int[,] array, int expected)
        {
            int result = TwoDimensionalArraysHelper.FindMaximumInArray(array);

            Assert.AreEqual(expected, result);
        }

        static readonly object[] MaxValueCases =
        {
            new object[]
            {
                new int[,]{ {25,0,1}, {2,4,6}, {10,-1,-2} }, 25
            },
            new object[]
            {
                new int[,]{ {-5,0,1}, {2,14,-6}, {10,-1,-2} }, 14
            },
            new object[]
            {
                new int[,]{ {-5,0,1}, {2,4,12}, {-10,12,-2} }, 12
            },
        };

        [TestCaseSource(nameof(MaxIndexCases))]
        public void FindMaximumIndexInArray_WhenFilledArrayPassed_ShouldMaxIndexes
            (int[,] array, (int, int) expected)
        {
            var result = TwoDimensionalArraysHelper.FindMaximumIndexInArray(array);

            Assert.AreEqual(expected, result);
        }

        static readonly object[] MaxIndexCases =
        {
            new object[]
            {
                new int[,]{ { 25, 0, 1 }, { 2, 4, 6 }, { 10, -1, -2 } }, ( 0, 0 )
            },
            new object[]
            {
                new int[,]{ { -5, 0, 1 }, { 2, 14, -6 }, { 10, -1, -2 } }, ( 1, 1 )
            },
            new object[]
            {
                new int[,]{ { -5, 0, 1 }, { 2, 4, 12 }, { -10, 12, -2 } }, ( 1, 2 )
            },
        };

        [TestCaseSource(nameof(CounterValueIsLargerNeighbors))]
        public void CounterValueIsLargerNeighbors_WhenFilledArrayPassed_ShouldCountNumbersGreaterNeighbors
            (int[,] array, int expected)
        {
            int result = TwoDimensionalArraysHelper.CounterValueIsLargerNeighbors(array);

            Assert.AreEqual(expected, result);
        }

        static readonly object[] CounterValueIsLargerNeighbors =
        {
            new object[]
            {
                new int[,]{ { 25, 0, 1 }, { 2, 4, 6 }, { 10, -1, -2 } }, 2
            },
            new object[]
            {
                new int[,]{ { -5, 24, 1 }, { 2, 14, -6 }, { 1, -1, -2 } }, 1
            },
            new object[]
            {
                new int[,]{ { 0, -1, 3, -2 }, { -4, 4, 1, 3 }, { 6, -3, 8, 7 }, { 10, 4, -7, 1 } }, 5
            },
        };
    }
}
