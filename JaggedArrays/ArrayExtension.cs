using System;

namespace JaggedArrays
{
    public static class ArrayExtension
    {
        public static int Sum(int[]? arr)
        {
            if (arr == null)
            {
                return 0;
            }

            int ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                ans += arr[i];
            }

            return ans;
        }

        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingBySum(this int[][]? source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = 0; j < source.Length - 1; j++)
                {
                    if (Sum(source[j]) > Sum(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by descending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingBySum(this int[][]? source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = 0; j < source.Length - 1; j++)
                {
                    if (Sum(source[j]) < Sum(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }

        public static int Max(int[]? arr)
        {
            if (arr == null)
            {
                return int.MinValue;
            }

            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (temp < arr[i])
                {
                    temp = arr[i];
                }
            }

            return temp;
        }

        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingByMax(this int[][]? source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = 0; j < source.Length - 1; j++)
                {
                    if (Max(source[j]) > Max(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by descending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingByMax(this int[][]? source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = 0; j < source.Length - 1; j++)
                {
                    if (Max(source[j]) < Max(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }
    }
}
