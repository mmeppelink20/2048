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
        public int Score { get; private set; }

        public int[,] CreateNewGameBoard()
        {
            int[,] gameBoard = new int[4, 4]
                            {
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            {0, 0, 0, 0 },
                            };

            Score = 0;

            newNumber(gameBoard);
            newNumber(gameBoard);

            return gameBoard;

        }

        public void newNumber(int[,] gameBoard) // create a new 2 or 4 on a random open (0) square.
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

        private int[,] _copyGameBoard(int[,] gameBoard) // creates a copy of the current gameboard to compare to the updated gameboard later.
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

        private Boolean _newTile(int[,] startingGameBoard, int[,] currentGameBoard) // determines whether a new tile is needed or not
        {
            Boolean newTile = false;
            for (int i = 0; i < currentGameBoard.GetLength(0); i++) // see if a new tile needs to be added
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

        public int[,] ShiftBoardRight(int[,] gameBoard)
        {
            int[,] startingGameBoard = _copyGameBoard(gameBoard);
            int startingScore = Score;

            for (int i = 0; i < gameBoard.GetLength(0); i++) // shift all the tiles to the right 
            {
                for (int count = 1; count <= 2; count++)
                {
                    for (int j = gameBoard.GetLength(0) - 1; j > 0; j--)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i, j - 1];
                            gameBoard[i, j - 1] = 0;
                        }

                    }
                }
            }

            for (int i = 0; i < gameBoard.GetLength(0); i++) // combine adjacent like tiles to the right
            {
                for (int j = gameBoard.GetLength(0) - 1; j > 0; j--)
                {
                    if (gameBoard[i, j - 1] == gameBoard[i, j])
                    {
                        gameBoard[i, j] += gameBoard[i, j - 1];
                        gameBoard[i, j - 1] = 0;
                        Score += gameBoard[i, j];
                    }
                }
            }

            for (int i = 0; i < gameBoard.GetLength(0); i++) // shift the combined tiles to the right
            {
                for (int count = 1; count <= 2; count++)
                {
                    for (int j = gameBoard.GetLength(0) - 1; j > 0; j--)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i, j - 1];
                            gameBoard[i, j - 1] = 0;

                        }

                    }
                }
            }

            if (_newTile(startingGameBoard, gameBoard))
            {
                newNumber(gameBoard);
            }



            return gameBoard;
        }



        public int[,] ShiftBoardLeft(int[,] gameBoard)
        {
            int[,] startingGameBoard = _copyGameBoard(gameBoard);
            int startingScore = Score;

            for (int count = 0; count < 3; count++)
            {
                for (int i = 0; i < gameBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < gameBoard.GetLength(0) - 1; j++)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i, j + 1];
                            gameBoard[i, j + 1] = 0;

                        }
                    }
                }

            }// shift all the tiles to the left

            for (int i = 0; i < gameBoard.GetLength(0); i++) // combine all of the tiles to the left
            {
                for (int j = 0; j < gameBoard.GetLength(0) - 1; j++)
                {
                    if (gameBoard[i, j + 1] == gameBoard[i, j])
                    {
                        gameBoard[i, j] += gameBoard[i, j + 1];
                        gameBoard[i, j + 1] = 0;
                        Score += gameBoard[i, j];
                    }
                }
            } // combine adjacent like tiles to the left

            for (int count = 0; count < 3; count++)// shift the combined tiles to the left
            {
                for (int i = 0; i < gameBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < gameBoard.GetLength(0) - 1; j++)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i, j + 1];
                            gameBoard[i, j + 1] = 0;
                        }
                    }
                }

            }// shift all the combined tiles to the left

            if (_newTile(startingGameBoard, gameBoard))
            {
                newNumber(gameBoard);
            }

            return gameBoard;
        }
        public int[,] ShiftBoardUp(int[,] gameBoard)
        {
           
            return gameBoard;
        }

    }
}
