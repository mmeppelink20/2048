using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;

namespace LogicLayer
{

    public class ShiftLogic
    {
        public int[,] CreateNewGameBoard()
        {
            int[,] gameBoard = new int[4, 4]
                            {
                            {0, 2, 4, 8 },
                            {16, 32, 64, 128 },
                            {256, 512, 1024, 2048 },
                            {4096, 0, 0, 0 },
                            };

            newNumber(gameBoard);
            newNumber(gameBoard);

            return gameBoard;

        }

        public void newNumber(int[,] gameBoard)
        {
            Random rand = new Random();

            int x1 = rand.Next(0, 4);
            int y1 = rand.Next(0, 4);

            int value1 = rand.Next(0, 16);

            if (value1 <= 10)
            {
                value1 = 2;
            }
            else
            {
                value1 = 4;
            }

            while (true)
            {
                if (gameBoard[x1, y1] == 0)
                {
                    gameBoard[x1, y1] = value1;
                    break;
                }
                else
                {
                    x1 = rand.Next(0, 4);
                    y1 = rand.Next(0, 4);
                }
            }

        }

        public int[,] ShiftBoardRight(int[,] gameBoard)
        {



            return gameBoard;
        }
    }
}
