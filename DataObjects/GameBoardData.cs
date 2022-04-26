using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class GameBoardData
    {
        public int Score {get; set;}

        public bool CheckIfLost(int[,] gameBoard)
        {
            bool lost = false;
            int count = 0;

            int countRight = 0;
            for (int i = 0; i < gameBoard.GetLength(0); i++) // check if any tiles can be shifted to the right
            {
                for (int j = gameBoard.GetLength(0) - 1; j > 0; j--)
                {
                    if (gameBoard[i, j - 1] == gameBoard[i, j] || gameBoard[i, j - 1] == 0)
                    {
                        countRight++;
                    }
                }
            }
            if (countRight == 0)
            {
                count++;
            }


            int countLeft = 0;
            for (int i = 0; i < gameBoard.GetLength(0); i++) // check if any tiles can be shifted to the left
            {
                for (int j = 0; j < gameBoard.GetLength(0) - 1; j++)
                {
                    if (gameBoard[i, j + 1] == gameBoard[i, j] || gameBoard[i, j + 1] == 0)
                    {
                        countLeft++;
                    }
                }
            }
            if (countLeft == 0)
            {
                count++;
            }


            int countUp = 0;
            for (int i = 0; i < gameBoard.GetLength(0) - 1; i++) // check if any tiles can be shifted up
            {
                for (int j = gameBoard.GetLength(0) - 1; j >= 0; j--)
                {
                    if (gameBoard[i + 1, j] == gameBoard[i, j] || gameBoard[i + 1, j] == 0)
                    {
                        countUp++;
                    }
                }
            }
            if (countUp == 0)
            {
                count++;
            }

            int countDown = 0;
            for (int i = gameBoard.GetLength(0) - 1; i > 0; i--) // check if any tiles can be shifted down
            {
                for (int j = 0; j <= gameBoard.GetLength(0) - 1; j++)
                {
                    if (gameBoard[i - 1, j] == gameBoard[i, j] || gameBoard[i - 1, j] == 0)
                    {
                        countDown++;
                    }
                }
            }
            if (countDown == 0)
            {
                count++;
            }

            if (count == 4)
            {
                lost = true;
            }

            return lost;
        }

        public int[,] CopyGameBoard(int[,] gameBoard) // creates a copy of the current gameboard to compare to the updated gameboard later.
        {
            int[,] startingGameBoard = new int[4, 4]
                            {
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            };

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(0); j++)
                {
                    startingGameBoard[i, j] = gameBoard[i, j];
                }
            }
            return startingGameBoard;
        }

        public bool NewTile(int[,] startingGameBoard, int[,] currentGameBoard) // determines whether a new tile is needed or not
        {
            bool newTile = false;
            for (int i = 0; i < currentGameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < currentGameBoard.GetLength(0); j++)
                {
                    if (startingGameBoard[i, j] != currentGameBoard[i, j])
                    {
                        newTile = true;
                    }
                }
            }
            return newTile;
        }

    }
}
