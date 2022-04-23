// Matthew Meppelink

using System;

namespace LogicLayer
{

    public class ShiftLogic
    {
        public int Score { get; set; }


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

            _newNumber(gameBoard);
            _newNumber(gameBoard);

            return gameBoard;

        }

        private void _newNumber(int[,] gameBoard) // creates a new 2 or 4 on a random open (0) square.
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());

            int x1 = rand.Next(0, 4);
            int y1 = rand.Next(0, 4);
            int i = 0;

            int value = 0;

            if (rand.Next(0, 10) <= 6)
            {
                value = 2;
            }
            else
            {
                value = 4;
            }

            while (true)
            {
                if (gameBoard[x1, y1] == 0)
                {
                    gameBoard[x1, y1] = value;
                    break;
                }
                else
                {
                    x1 = rand.Next(0, 4);
                    y1 = rand.Next(0, 4);
                    i++;
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

        private bool _newTile(int[,] startingGameBoard, int[,] currentGameBoard) // determines whether a new tile is needed or not
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


        public int[,] ShiftBoardRight(int[,] gameBoard) // shifts the gameboard to the right
        {
            int[,] startingGameBoard = _copyGameBoard(gameBoard);

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

            for (int i = 0; i < gameBoard.GetLength(0); i++)// shift all the combined tiles to the right
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

            if (_newTile(startingGameBoard, gameBoard)) // see if new tile needs to be added
            {
                _newNumber(gameBoard);
            }

            return gameBoard;
        }

        public int[,] ShiftBoardLeft(int[,] gameBoard) // shifts the gameboard to the left
        {
            int[,] startingGameBoard = _copyGameBoard(gameBoard);


            for (int i = 0; i < gameBoard.GetLength(0); i++)// shift all the tiles to the left
            {
                for (int count = 0; count < 3; count++)
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
            }

            for (int i = 0; i < gameBoard.GetLength(0); i++) // combine adjacent like tiles to the left
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
            }

            for (int i = 0; i < gameBoard.GetLength(0); i++)// shift all the combined tiles to the left
            {
                for (int count = 0; count < 3; count++)
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
            }

            if (_newTile(startingGameBoard, gameBoard))//see if new tile needs to be added
            {
                _newNumber(gameBoard);
            }



            return gameBoard;
        }

        public int[,] ShiftBoardUp(int[,] gameBoard) // shifts the gameboard up
        {
            int[,] startingGameBoard = _copyGameBoard(gameBoard);
            int startingScore = Score;

            for (int count = 1; count <= 2; count++) // shift all the tiles up
            {
                for (int i = 0; i < gameBoard.GetLength(0) - 1; i++)
                {
                    for (int j = gameBoard.GetLength(0) - 1; j >= 0; j--)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i + 1, j];
                            gameBoard[i + 1, j] = 0;
                        }
                    }
                }
            }


            for (int i = 0; i < gameBoard.GetLength(0) - 1; i++) // combine adjacent like tiles up
            {
                for (int j = gameBoard.GetLength(0) - 1; j >= 0; j--)
                {
                    if (gameBoard[i + 1, j] == gameBoard[i, j])
                    {
                        gameBoard[i, j] += gameBoard[i + 1, j];
                        gameBoard[i + 1, j] = 0;
                        Score += gameBoard[i, j];
                    }
                }
            }

            for (int count = 1; count <= 2; count++) // shift the combined tiles up
            {
                for (int i = 0; i < gameBoard.GetLength(0) - 1; i++)
                {
                    for (int j = gameBoard.GetLength(0) - 1; j >= 0; j--)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i + 1, j];
                            gameBoard[i + 1, j] = 0;
                        }
                    }
                }
            }

            if (_newTile(startingGameBoard, gameBoard))//see if new tile needs to be added
            {

                _newNumber(gameBoard);
            }


            return gameBoard;
        }

        public int[,] ShiftBoardDown(int[,] gameBoard) // shifts the gameboard down
        {
            int[,] startingGameBoard = _copyGameBoard(gameBoard);
            int startingScore = Score;

            for (int count = 1; count <= 2; count++) // shift all the tiles up
            {
                for (int i = gameBoard.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j <= gameBoard.GetLength(0) - 1; j++)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i - 1, j];
                            gameBoard[i - 1, j] = 0;
                        }
                    }
                }
            }

            for (int i = gameBoard.GetLength(0) - 1; i > 0; i--) // combine adjacent like tiles down
            {
                for (int j = 0; j <= gameBoard.GetLength(0) - 1; j++)
                {
                    if (gameBoard[i - 1, j] == gameBoard[i, j])
                    {
                        gameBoard[i, j] += gameBoard[i - 1, j];
                        gameBoard[i - 1, j] = 0;
                        Score += gameBoard[i, j];
                    }
                }
            }

            for (int count = 1; count <= 2; count++) // shift all the tiles down
            {
                for (int i = gameBoard.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j <= gameBoard.GetLength(0) - 1; j++)
                    {
                        if (gameBoard[i, j] == 0)
                        {
                            gameBoard[i, j] += gameBoard[i - 1, j];
                            gameBoard[i - 1, j] = 0;
                        }
                    }
                }
            }

            if (_newTile(startingGameBoard, gameBoard))//see if new tile needs to be added
            {
                _newNumber(gameBoard);
            }

            return gameBoard;
        }

    }
}
