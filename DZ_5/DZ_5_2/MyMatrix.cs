using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_2
{
    internal class MyMatrix
    {
        private int[,] matrix;

        
        public MyMatrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
        }

        
        public void SetElement(int row, int column, int value)
        {
            matrix[row, column] = value;
        }

        
        public int GetElement(int row, int column)
        {
            return matrix[row, column];
        }

        
        public void PrintMatrix()
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
