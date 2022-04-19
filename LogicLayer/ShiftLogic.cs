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
        public static int[,] CreateNewGameBoard()
        {
            int[,] gameBoard = new int[3, 3];

            Random rand = new Random();
            int updates = 0;

            for (int i = 0; i < gameBoard.Length - 1; i++)
            {
                for (int j = 0; j < gameBoard.Length - 1; j++)
                {
                    if (rand.Next(0, 16) < 10)
                    {
                        gameBoard[i, j] = 2;
                        updates++;
                        if (updates <= 2)
                        {
                            break;
                        }
                    }
                    else
                    {
                        gameBoard[i, j] = 4;
                        updates++;
                        if (updates <= 2)
                        {
                            break;
                        }
                    }
                }
                if(updates <= 2)
                {
                    break;
                }

            }
            return gameBoard;

        }

    }
}
