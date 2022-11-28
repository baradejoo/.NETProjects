using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja7
{
    class Program
    {
        struct Size
        {
            public uint rows, cols;

            public Size(uint rows, uint cols)
            {
                this.rows = rows;
                this.cols = cols;
            }
        }
        class Matrix
        {
            private int[] _matrix;
            private uint l;
            private uint c;

            public Size Size => new Size(l, c);

            public Matrix(uint lines, uint cols, int[] initial)
            {
                l = lines;
                c = cols;
                _matrix = new int[lines * cols];
                initial.CopyTo(_matrix, 0);
            }

            private bool coordsAreInBounds(uint line, uint column) => line * c + column < l * c;
            private uint coordsToArrayIdx(uint line, uint column) => coordsToArrayIdx(line, column, c);

            private static uint coordsToArrayIdx(uint i, uint j, uint cols) => (i * cols + j);

            private Size arrayIdxToCoords(uint idx)
            {
                var col = idx % c;
                var row = (idx - col) / l;
                return new Size(row, col);
            }

            public int Get(uint row, uint col)
            {
                if (!coordsAreInBounds(row, col))
                    throw new IndexOutOfRangeException("Matrix coords out of bounds");

                return _matrix[coordsToArrayIdx(row, col)];
            }

            public void AddElem(uint row, uint col, int elem)
            {
                if (!coordsAreInBounds(row, col))
                    throw new IndexOutOfRangeException("Matrix coords out of bounds");

                _matrix[coordsToArrayIdx(row, col)] += elem;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (uint row = 0; row < l; row++)
                {
                    sb.Append("[ ");
                    for (uint col = 0; col < c; col++)
                    {
                        var val = _matrix[coordsToArrayIdx(row, col)];
                        sb.AppendFormat("{0,2} ", val);
                    }

                    sb.AppendLine("]");
                }
                return sb.ToString();
            }

            public static Matrix operator +(Matrix matrix1, Matrix matrix2)
            {
                return Matrix.AddMatrix(matrix1, matrix2);
            }

     
            public static Matrix AddMatrix(Matrix matrix1, Matrix matrix2)
            {
                var m1Size = matrix1.Size;
                var m2Size = matrix2.Size;
                var rows = Math.Max(m1Size.rows, m2Size.rows);
                var cols = Math.Max(m1Size.cols, m2Size.cols);
                var newArr = new int[rows * cols];
                for (uint i = 0; i < rows; i++)
                    for (uint j = 0; j < cols; j++)
                    {
                        var idx = coordsToArrayIdx(i, j, cols);
                        if (i < m1Size.rows && j < m1Size.cols)
                            newArr[idx] += matrix1.Get(i, j);

                        if (i < m2Size.rows && j < m2Size.cols)
                            newArr[idx] += matrix2.Get(i, j);
                    }

                return new Matrix(rows, cols, newArr);
            }
        }
        static void Main(string[] args)
        {
            // indeksy wierszy/kolumn są 0-based
            var mat1 = new Matrix(2, 3, new[] { 1, 2, 3, 4 });
            Console.WriteLine("Macierz 1:");
            Console.WriteLine(mat1);

            mat1.AddElem(0, 1, 3);
            mat1.AddElem(1, 2, 5);
            Console.WriteLine("Macierz 1 po dodaniu 3 na pozycji (1,2)");
            Console.WriteLine("oraz 5 na pozycji (2,3):");
            Console.WriteLine(mat1);
        
            var mat2 = new Matrix(3, 2, new[] { 5, 6, 7, 8, 9 });
            Console.WriteLine("Macierz 2:");
            Console.WriteLine(mat2);
       
            var mat3 = mat1 + mat2; // uzywam przeladowanego operatora +
            Console.WriteLine("Suma macierzy 1 i 2:");
            Console.WriteLine(mat3);
            Console.ReadKey();
       
        }
    }
}