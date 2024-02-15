using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTail
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> myList = new List<string>()
            {
               "A_Yellow", "B_Red", "C_Yellow", "B_Red", "D_Yellow", "C_Red", "B_Yellow", "C_Red", "E_Yellow", "D_Red", "E_Yellow", "D_Red", "A_Yellow", "D_Red", "G_Yellow", "E_Red", "A_Yellow", "E_Red"
            };
            Console.WriteLine(WhoIsWinner(myList));
            
        }

        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            char[,] positionsColors = distribution(piecesPositionList);
          
            int verticallyR = 0;
            int verticallyY = 0;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (positionsColors[i, j] != 0)
                    {
                        if (positionsColors[i, j] == 'R' && positionsColors[i, j + 1] == 'R')
                        {
                            ++verticallyR;
                        }
                        else
                            verticallyR = 0;

                        if (positionsColors[i, j] == 'Y' && positionsColors[i, j + 1] == 'Y')
                        {
                            ++verticallyY;
                        }
                        else
                            verticallyY = 0;

                        if (verticallyR == 3)
                            return "Red";
                        if (verticallyY == 3)
                            return "Yellow";
                    }
                }
            }

                int horizontallyR = 0;
                int horizontallyY = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (positionsColors[j, i] != 0)
                    {
                        if (positionsColors[j, i] == 'R' && positionsColors[j + 1, i] == 'R')
                        {
                            ++horizontallyR;
                        }
                        else
                            horizontallyR = 0;

                        if (positionsColors[j, i] == 'Y' && positionsColors[j + 1, i] == 'Y')
                        {
                            ++horizontallyY;
                        }
                        else
                            horizontallyY = 0;

                        if (horizontallyR == 3)
                            return "Red";
                        if (horizontallyY == 3)
                            return "Yellow";
                    }
                   
                }

            }

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                    if (positionsColors[i, j] == 'R' && FromDownToTopRifght(i, j, positionsColors, 'R'))
                        return "Red";

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                    if (positionsColors[i, j] == 'Y' && FromDownToTopRifght(i, j, positionsColors, 'Y'))
                        return "Yellow";

            for (int i = 6; i >= 0; i++)
                for (int j = 5; j >= 0; j++)
                    if (positionsColors[i, j] == 'R' && FromDownToTopLeft(i, j, positionsColors, 'R'))
                        return "Red";

            for (int i = 6; i >= 0; i++)
                for (int j = 5; j >= 0; j++)
                    if (positionsColors[i, j] == 'Y' && FromDownToTopLeft(i, j, positionsColors, 'Y'))
                        return "Yellow";




            return "Draw";
        }

        private static bool FromDownToTopRifght(int x, int y, char[,] a, char letter)
        {
            if (a[x + 1, y + 1] ==
letter)
                if (a[x + 2, y + 2] == letter)
                    if (a[x + 3, y + 3] == letter)
                            return true;
            return false;
        }

        private static bool FromDownToTopLeft(int x, int y, char[,] a, char letter)
        {
            if (a[x - 1, y - 1] == letter)
                if (a[x - 2, y - 2] == letter)
                    if (a[x - 3, y - 3] == letter)
                        return true;
            return false;
        }


        public static char[,] distribution(List<string> piecesPositionList)
        {
            char[,] positionsColors = new char[7, 6];
            byte A = 0;
            byte B = 0;
            byte C = 0;
            byte D = 0;
            byte E = 0;
            byte F = 0;
            byte G = 0;


            for (int i = 0; i < piecesPositionList.Count; i++)
            {
                string position = piecesPositionList[i];
                char letter = position[0];
                char color = position[2];

                switch (letter)
                {
                    case 'A':
                        positionsColors[0, A++] = color;
                        break;
                    case 'B':
                        positionsColors[1, B++] = color;
                        break;
                    case 'C':
                        positionsColors[2, C++] = color;
                        break;
                    case 'D':
                        positionsColors[3, D++] = color;
                        break;
                    case 'E':
                        positionsColors[4, E++] = color;
                        break;
                    case 'F':
                        positionsColors[5, F++] = color;
                        break;
                    case 'G':
                        positionsColors[6, G++] = color;
                        break;

                }

            }
            return positionsColors;
        }

    }
}
