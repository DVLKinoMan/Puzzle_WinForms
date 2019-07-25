using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class PuzzleMatrix
    {
        private int[,] intMatrix;
        private int[,] firstMatrix;

        public PuzzleMatrix(int Level)
        {
            Matrix=new int[Level,Level];
            firstPosition();
        }

        public bool won()
        {
            if (isEqualMatrixes(firstMatrix, Matrix))
                return true;
            else return false;
        }

        public void randomMatrix()
        {
            Random rn = new Random();
            for (int i = 1; i <= 2000; i++)
            {
                int num = rn.Next(1, 5);
                switch (num)
                {
                    case 1:
                        upMove();
                        break;
                   case 2:
                        downMove();
                        break;
                    case 3:
                        leftMove();
                        break;
                    default:
                        rightMove();
                        break;
                }
            }
            if (won())
                while (!won())
                    randomMatrix();
        }

        #region Move Functions
        public void upMove()
        {
            int row = getNumberPositionRow(0);
            int column = getNumberPositionColumn(0);
            if(row!=-1 && column!=-1)
                if (row + 1 < Matrix.GetLength(0))
                {
                    Matrix[row, column] = Matrix[row + 1, column];
                    Matrix[row + 1, column] = 0;
                }
        }

        public void downMove()
        {
            int row = getNumberPositionRow(0);
            int column = getNumberPositionColumn(0);
            if (row != -1 && column != -1)
                if (row - 1 >= 0)
                {
                    Matrix[row, column] = Matrix[row - 1, column];
                    Matrix[row - 1, column] = 0;
                }
        }

        public void leftMove()
        {
            int row = getNumberPositionRow(0);
            int column = getNumberPositionColumn(0);
            if (row != -1 && column != -1)
                if (column + 1 < Matrix.GetLength(1))
                {
                    Matrix[row, column] = Matrix[row, column + 1];
                    Matrix[row, column + 1] = 0;
                }
        }

        public void rightMove()
        {
            int row = getNumberPositionRow(0);
            int column = getNumberPositionColumn(0);
            if (row != -1 && column != -1)
                if (column - 1 >= 0)
                {
                    Matrix[row, column] = Matrix[row, column - 1];
                    Matrix[row, column - 1] = 0;
                }
        }
        #endregion

        public int getNumberPositionRow(int num)
        {
            int rowNum = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    if (Matrix[i, j] == num)
                        return rowNum;
                rowNum++;
            }
            return -1;
        }

        public int getNumberPositionRowOfMatrix(int num, int[,] m)
        {
            int rowNum = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    if (m[i, j] == num)
                        return rowNum;
                rowNum++;
            }
            return -1;
        }

        public int getNumberPositionColumn(int num)
        {
            int rowCol = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == num)
                        return rowCol;
                    rowCol++;
                }
                rowCol = 0;
            }
            return -1;
        }

        public int getNumberPositionColumnOfMatrix(int num, int[,] m)
        {
            int rowCol = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] == num)
                        return rowCol;
                    rowCol++;
                }
                rowCol = 0;
            }
            return -1;
        }

        public static int[,] getMatrix(int[,] m)
        {
            int[,] mNew = new int[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < mNew.GetLength(0); i++)
                for (int j = 0; j < mNew.GetLength(1); j++)
                    mNew[i, j] = m[i, j];
            return mNew;
        }

        public static bool isEqualMatrixes(int[,] m1, int[,] m2)
        {
            if (m1.GetLength(0) != m2.GetLength(0) || m1.GetLength(1) != m2.GetLength(1))
                return false;
            else
            {
                for(int i=0;i<m1.GetLength(0);i++)
                    for(int j=0;j<m1.GetLength(1);j++)
                        if(m1[i,j]!=m2[i,j])
                            return false;
                return true;
            }
        }

        #region Private Functions
        private void firstPosition()
        {
            int num=1;
            for(int i=0;i<Matrix.GetLength(0);i++)
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (i == Matrix.GetLength(0) - 1 && j == Matrix.GetLength(1) - 1)
                        Matrix[i, j] = 0;
                    else Matrix[i, j] = num;
                    num++;
                }
            firstMatrix = getMatrix(Matrix);
        }
        #endregion

        public int[,] Matrix
        {
            get
            {
                return this.intMatrix;
            }
            set
            {
                this.intMatrix = value;
            }
        }

        public int[,] FirstMatrix
        {
            get { return firstMatrix; }
            set { firstMatrix = value; }
        }

    }
}
