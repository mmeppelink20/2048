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
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            };


            _newNumber(gameBoard, 2);

            return gameBoard;

        }

        private void _newNumber(int[,] gameBoard, int count)
        {
            Random rand = new Random();

            int x1 = rand.Next(0, 4);
            int y1 = rand.Next(0, 4);


            int x2 = rand.Next(0, 4);
            int y2 = rand.Next(0, 4);

            if (x2 == x1)
            {
                x2 = rand.Next(0, 4);
            }
            if (y2 == y1)
            {
                y2 = rand.Next(0, 4);
            }

            int value1 = rand.Next(0, 16);
            int value2 = rand.Next(0, 16);

            if (value1 <= 10)
            {
                value1 = 2;
            }
            else
            {
                value1 = 4;
            }

            if (value2 <= 10)
            {
                value2 = 2;
            }
            else
            {
                value2 = 4;
            }

            gameBoard[x1, y1] = value1;
            gameBoard[x2, y2] = value2;


        }

    }
}
