using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonogramOfficial.Helpers
{
    public static class ArrayConverter
    {
        public static int[][] ToJagged(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[][] jagged = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jagged[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    jagged[i][j] = array[i, j];
                }
            }

            return jagged;
        }

        public static int[,] To2D(int[][] jagged)
        {
            int rows = jagged.Length;
            int cols = jagged[0].Length;
            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = jagged[i][j];
                }
            }

            return array;
        }
    }
}
