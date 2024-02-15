using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectFour
{
    internal class Program
    {
        private const int Rows = 7;
        private const int Columns = 6;

        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            {
              "A_Red",
"A_Yellow",
"A_Yellow",
"A_Yellow",
"A_Red",
"A_Red",
"B_Yellow",
"B_Yellow",
"B_Red", "B_Red",
"B_Red",
"B_Yellow",
"C_Yellow", "C_Red",
"C_Yellow",
"C_Yellow",
"C_Yellow",
"C_Red",
"D_Red",
"D_Red",
"D_Red",
"D_Yellow",
"D_Yellow",
"D_Yellow",
"E_Yellow",
"E_Red",
"E_Red",
"E_Yellow",
"E_Red",
"E_Red",
"F_Red",
"F_Yellow",
"F_Yellow",
"F_Red",
"F_Red",
"F_Yellow",
"G_Yellow",
"G_Red",
"G_Red",
"G_Yellow",
"G_Yellow",
"G_Red"
};
            Console.WriteLine(WhoIsWinner(myList));
        }

        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            var positionsColors = distribution(piecesPositionList);

            if (CheckVerticalWin(positionsColors, 'R') || CheckHorizontalWin(positionsColors, 'R') || CheckDiagonalWin(positionsColors, 'R'))
                return "Red";
            if (CheckVerticalWin(positionsColors, 'Y') ||  CheckHorizontalWin(positionsColors, 'Y') || CheckDiagonalWin(positionsColors, 'Y'))
                return "Yellow";

            return "Draw";
        }

        private static bool CheckVerticalWin(char[,] positionsColors, char color)
        {
            for (int i = 0; i < Rows - 3; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (positionsColors[i, j] == color && positionsColors[i + 1, j] == color && positionsColors[i + 2, j] == color && positionsColors[i + 3, j] == color)
                        return true;
                }
            }
            return false;
        }

        private static bool CheckHorizontalWin(char[,] positionsColors, char color)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns - 3; j++)
                {
                    if (positionsColors[i, j] == color && positionsColors[i, j + 1] == color && positionsColors[i, j + 2] == color && positionsColors[i, j + 3] == color)
                        return true;
                }
            }
            return false;
        }

        private static bool CheckDiagonalWin(char[,] positionsColors, char color)
        {
            for (int i = 0; i < Rows - 3; i++)
            {
                for (int j = 0; j < Columns - 3; j++)
                {
                    if (positionsColors[i, j] == color && positionsColors[i + 1, j + 1] == color && positionsColors[i + 2, j + 2] == color && positionsColors[i + 3, j + 3] == color)
                        return true;
                    if (positionsColors[i + 3, j] == color && positionsColors[i + 2, j + 1] == color && positionsColors[i + 1, j + 2] == color && positionsColors[i, j + 3] == color)
                        return true;
                }
            }
            return false;
        }

        private static char[,] distribution(List<string> piecesPositionList)
        {
            char[,] positionsColors = new char[Rows, Columns];
            int[] letterCounts = new int[7];

            foreach (var position in piecesPositionList)
            {
                char letter = position[0];
                char color = position[2];

                int index = letter - 'A';
                positionsColors[index, letterCounts[index]++] = color;
            }
            return positionsColors;
        }
    }
}
