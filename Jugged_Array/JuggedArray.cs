using System;
using System.Collections.Generic;
using System.Text;

// Class : поле Jugged array  int [][] matrix
// к-р приймає кількість колонок у кожному рядку як params int []+
// властивості для читання Rows  get +
// метод Columns(int row) ???
// двовимірний індексатор indexator +
// заповнення вип числами +
// ToString()+

namespace Jugged_Array
{
    class JuggedArray
    {
        int[][] matrix;
        public JuggedArray(params int[] colums)
        {
            matrix = new int[colums.Length][];
            for (int i = 0; i < colums.Length; i++)
            {
                matrix[i] = new int[colums[i]];
            }
        }

        public int Rows
        {
            get => matrix.Length;
        }
        public int Colums(int row)
        {
            if(row<matrix.Length)
                return matrix[row].Length;
            throw new Exception("Error row (metod Colums)");
        }
        public int this[int row, int col]
        {
            get
            {
                if (row >= matrix.Length || row < 0)
                    throw new Exception("Row error");

                if (col >= matrix[row].Length || col < 0)
                    throw new Exception("Col error");

                return matrix[row][col];
            }
            set
            {
                if (row >= matrix.Length || row < 0)
                    throw new Exception("Row error");

                if (col >= matrix[row].Length || col < 0)
                    throw new Exception("Col error");

                matrix[row][col] = value;
            }
        }
        public int[] this[int row]
        {
            get
            {
                if (row >= matrix.Length || row < 0)
                    throw new Exception("Row error");
                return matrix[row];
            }
            set
            {
                if (row >= matrix.Length || row < 0)
                    throw new Exception("Row error");
                matrix [row] = value;
            }
        }
        public void FillRand(int first, int last)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rand.Next(first, last+1);
                }
            }
        }
        public override string ToString()
        {
            string arr = "", temp;
            foreach (var item in matrix)
            {
                temp = String.Join("\t", item);
                arr += temp + "\n";
            }
            return arr;
        }

    }
}
