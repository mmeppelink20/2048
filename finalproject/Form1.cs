// Matthew Meppelink
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;


namespace TwentyFoutyEight
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private int[,] _gameBoard;
        private ShiftLogic _shiftLogic = new ShiftLogic();
        private GameBoardData gameBoardData;
        private Score _score = new Score();


        private void Form1_Load(object sender, EventArgs e)
        {
            _gameBoard = _shiftLogic.CreateNewGameBoard();
            gameBoardData = _shiftLogic.GameBoardData;
            _updateBoard();
            _updateScore();
            lblGameOver.Visible = false;
            btnGameOver.Visible = false;
            lblGameOverBorder.Visible = false;

        }


        // controls
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
            {
                _shiftLogic.ShiftBoardLeft(_gameBoard);
                _updateBoard();
                _updateScore();
                if (gameBoardData.CheckIfLost(_gameBoard))
                {
                    lblGameOver.Visible = true;
                    btnGameOver.Visible = true;
                    lblGameOverBorder.Visible = true;
                }

            }
            if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
            {
                _shiftLogic.ShiftBoardRight(_gameBoard);
                _updateBoard();
                _updateScore();
                if (gameBoardData.CheckIfLost(_gameBoard))
                {
                    lblGameOver.Visible = true;
                    btnGameOver.Visible = true;
                    lblGameOverBorder.Visible = true;
                }
            }
            if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
            {
                _shiftLogic.ShiftBoardUp(_gameBoard);
                _updateBoard();
                _updateScore();
                if (gameBoardData.CheckIfLost(_gameBoard))
                {
                    lblGameOver.Visible = true;
                    btnGameOver.Visible = true;
                    lblGameOverBorder.Visible = true;
                }
            }
            if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
            {
                _shiftLogic.ShiftBoardDown(_gameBoard);
                _updateBoard();
                _updateScore();
                if (gameBoardData.CheckIfLost(_gameBoard))
                {
                    lblGameOver.Visible = true;
                    btnGameOver.Visible = true;
                    lblGameOverBorder.Visible = true;
                }
            }
            try
            {
                _score.SavePlayerScore(gameBoardData.Score);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
        }

        // controls
        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
            if (keys.Contains(e.KeyData))
                e.IsInputKey = true;
        }

        // Updates the score
        private void _updateScore()
        {
            labelScore.Text = gameBoardData.Score.ToString();
            if (gameBoardData.Score > _score.RestoreSavedScore())
            {
                labelHighScore.Text = gameBoardData.Score.ToString();
            }
            else
            {
                try
                {
                    labelHighScore.Text = _score.RestoreSavedScore().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
                }
            }
        }

        private void btnClearHighScore_Click(object sender, EventArgs e)
        {
            try
            {
                _score.SetScoreZero(gameBoardData.Score, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
            _updateScore();
        }

        // Updates the color, font, and font color according to the value in _gameBoard[,].
        private void _updateTileColor()
        {
            Color color0 = Color.FromArgb(182, 170, 157);

            Color color2 = Color.FromArgb(238, 228, 218);
            Color color4 = Color.FromArgb(237, 223, 201);
            Color color8 = Color.FromArgb(242, 177, 120);
            Color color16 = Color.FromArgb(245, 148, 99);

            Color color32 = Color.FromArgb(246, 124, 95);
            Color color64 = Color.FromArgb(246, 94, 59);
            Color color128 = Color.FromArgb(237, 206, 115);
            Color color256 = Color.FromArgb(238, 204, 98);

            Color color512 = Color.FromArgb(237, 200, 80);
            Color color1024 = Color.FromArgb(238, 196, 63);
            Color color2048 = Color.FromArgb(237, 194, 46);
            Color color4096 = Color.FromArgb(60, 58, 50);

            Color _textColorWhite = Color.White;
            Color _textColorBlack = Color.Black;

            Font _fontTen = new Font("Microsoft YaHei UI", 48, FontStyle.Bold);
            Font _fontHundred = new Font("Microsoft YaHei UI", 44, FontStyle.Bold);
            Font _fontThousand = new Font("Microsoft YaHei UI", 33, FontStyle.Bold);

            // 1, 1
            int tileValue = _gameBoard[0, 0];
            switch (tileValue)
            {
                case 0:
                    lblOneOne.BackColor = color0;
                    lblOneOne.ForeColor = _textColorBlack;
                    lblOneOne.Font = _fontTen;
                    break;
                case 2:
                    lblOneOne.BackColor = color2;
                    lblOneOne.ForeColor = _textColorBlack;
                    lblOneOne.Font = _fontTen;
                    break;
                case 4:
                    lblOneOne.BackColor = color4;
                    lblOneOne.ForeColor = _textColorBlack;
                    lblOneOne.Font = _fontTen;
                    break;
                case 8:
                    lblOneOne.BackColor = color8;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontTen;
                    break;
                case 16:
                    lblOneOne.BackColor = color16;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontTen;
                    break;
                case 32:
                    lblOneOne.BackColor = color32;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 64:
                    lblOneOne.BackColor = color64;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontTen;
                    break;
                case 128:
                    lblOneOne.BackColor = color128;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontHundred;
                    break;
                case 256:
                    lblOneOne.BackColor = color256;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontHundred;
                    break;
                case 512:
                    lblOneOne.BackColor = color512;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontHundred;
                    break;
                case 1024:
                    lblOneOne.BackColor = color1024;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontThousand;
                    break;
                case 2048:
                    lblOneOne.BackColor = color2048;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblOneOne.BackColor = color4096;
                    lblOneOne.ForeColor = _textColorWhite;
                    lblOneOne.Font = _fontThousand;
                    break;
            }
            // 1, 2
            tileValue = _gameBoard[0, 1];
            switch (tileValue)
            {
                case 0:
                    lblOneTwo.BackColor = color0;
                    lblOneTwo.ForeColor = _textColorBlack;
                    lblOneTwo.Font = _fontTen;
                    break;
                case 2:
                    lblOneTwo.BackColor = color2;
                    lblOneTwo.ForeColor = _textColorBlack;
                    lblOneTwo.Font = _fontTen;
                    break;
                case 4:
                    lblOneTwo.BackColor = color4;
                    lblOneTwo.ForeColor = _textColorBlack;
                    lblOneTwo.Font = _fontTen;
                    break;
                case 8:
                    lblOneTwo.BackColor = color8;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontTen;
                    break;
                case 16:
                    lblOneTwo.BackColor = color16;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontTen;
                    break;
                case 32:
                    lblOneTwo.BackColor = color32;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontTen;
                    break;
                case 64:
                    lblOneTwo.BackColor = color64;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontTen;
                    break;
                case 128:
                    lblOneTwo.BackColor = color128;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontHundred;
                    break;
                case 256:
                    lblOneTwo.BackColor = color256;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontHundred;
                    break;
                case 512:
                    lblOneTwo.BackColor = color512;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontHundred;
                    break;
                case 1024:
                    lblOneTwo.BackColor = color1024;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontThousand;
                    break;
                case 2048:
                    lblOneTwo.BackColor = color2048;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblOneTwo.BackColor = color4096;
                    lblOneTwo.ForeColor = _textColorWhite;
                    lblOneTwo.Font = _fontThousand;
                    break;
            }
            // 1, 3
            tileValue = _gameBoard[0, 2];
            switch (tileValue)
            {
                case 0:
                    lblOneThree.BackColor = color0;
                    lblOneThree.ForeColor = _textColorBlack;
                    lblOneThree.Font = _fontTen;
                    break;
                case 2:
                    lblOneThree.BackColor = color2;
                    lblOneThree.ForeColor = _textColorBlack;
                    lblOneThree.Font = _fontTen;
                    break;
                case 4:
                    lblOneThree.BackColor = color4;
                    lblOneThree.ForeColor = _textColorBlack;
                    lblOneThree.Font = _fontTen;
                    break;
                case 8:
                    lblOneThree.BackColor = color8;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontTen;
                    break;
                case 16:
                    lblOneThree.BackColor = color16;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontTen;
                    break;
                case 32:
                    lblOneThree.BackColor = color32;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontTen;
                    break;
                case 64:
                    lblOneThree.BackColor = color64;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontTen;
                    break;
                case 128:
                    lblOneThree.BackColor = color128;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontHundred;
                    break;
                case 256:
                    lblOneThree.BackColor = color256;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontHundred;
                    break;
                case 512:
                    lblOneThree.BackColor = color512;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontHundred;
                    break;
                case 1024:
                    lblOneThree.BackColor = color1024;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontThousand;
                    break;
                case 2048:
                    lblOneThree.BackColor = color2048;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblOneThree.BackColor = color4096;
                    lblOneThree.ForeColor = _textColorWhite;
                    lblOneThree.Font = _fontThousand;
                    break;
            }
            // 1, 4
            tileValue = _gameBoard[0, 3];
            switch (tileValue)
            {
                case 0:
                    lblOneFour.BackColor = color0;
                    lblOneFour.ForeColor = _textColorBlack;
                    lblOneFour.Font = _fontTen;
                    break;
                case 2:
                    lblOneFour.BackColor = color2;
                    lblOneFour.ForeColor = _textColorBlack;
                    lblOneFour.Font = _fontTen;
                    break;
                case 4:
                    lblOneFour.BackColor = color4;
                    lblOneFour.ForeColor = _textColorBlack;
                    lblOneFour.Font = _fontTen;
                    break;
                case 8:
                    lblOneFour.BackColor = color8;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontTen;
                    break;
                case 16:
                    lblOneFour.BackColor = color16;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontTen;
                    break;
                case 32:
                    lblOneFour.BackColor = color32;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontTen;
                    break;
                case 64:
                    lblOneFour.BackColor = color64;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontTen;
                    break;
                case 128:
                    lblOneFour.BackColor = color128;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontHundred;
                    break;
                case 256:
                    lblOneFour.BackColor = color256;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontHundred;
                    break;
                case 512:
                    lblOneFour.BackColor = color512;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontHundred;
                    break;
                case 1024:
                    lblOneFour.BackColor = color1024;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontThousand;
                    break;
                case 2048:
                    lblOneFour.BackColor = color2048;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblOneFour.BackColor = color4096;
                    lblOneFour.ForeColor = _textColorWhite;
                    lblOneFour.Font = _fontThousand;
                    break;
            }


            // 2, 1
            tileValue = _gameBoard[1, 0];
            switch (tileValue)
            {
                case 0:
                    lblTwoOne.BackColor = color0;
                    lblTwoOne.ForeColor = _textColorBlack;
                    lblTwoOne.Font = _fontTen;
                    break;
                case 2:
                    lblTwoOne.BackColor = color2;
                    lblTwoOne.ForeColor = _textColorBlack;
                    lblTwoOne.Font = _fontTen;
                    break;
                case 4:
                    lblTwoOne.BackColor = color4;
                    lblTwoOne.ForeColor = _textColorBlack;
                    lblTwoOne.Font = _fontTen;
                    break;
                case 8:
                    lblTwoOne.BackColor = color8;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontTen;
                    break;
                case 16:
                    lblTwoOne.BackColor = color16;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontTen;
                    break;
                case 32:
                    lblTwoOne.BackColor = color32;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontTen;
                    break;
                case 64:
                    lblTwoOne.BackColor = color64;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontTen;
                    break;
                case 128:
                    lblTwoOne.BackColor = color128;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontHundred;
                    break;
                case 256:
                    lblTwoOne.BackColor = color256;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontHundred;
                    break;
                case 512:
                    lblTwoOne.BackColor = color512;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontHundred;
                    break;
                case 1024:
                    lblTwoOne.BackColor = color1024;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontThousand;
                    break;
                case 2048:
                    lblTwoOne.BackColor = color2048;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoOne.BackColor = color4096;
                    lblTwoOne.ForeColor = _textColorWhite;
                    lblTwoOne.Font = _fontThousand;
                    break;
            }
            // 2, 2
            tileValue = _gameBoard[1, 1];
            switch (tileValue)
            {
                case 0:
                    lblTwoTwo.BackColor = color0;
                    lblTwoTwo.ForeColor = _textColorBlack;
                    lblTwoTwo.Font = _fontTen;
                    break;
                case 2:
                    lblTwoTwo.BackColor = color2;
                    lblTwoTwo.ForeColor = _textColorBlack;
                    lblTwoTwo.Font = _fontTen;
                    break;
                case 4:
                    lblTwoTwo.BackColor = color4;
                    lblTwoTwo.ForeColor = _textColorBlack;
                    lblTwoTwo.Font = _fontTen;
                    break;
                case 8:
                    lblTwoTwo.BackColor = color8;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontTen;
                    break;
                case 16:
                    lblTwoTwo.BackColor = color16;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontTen;
                    break;
                case 32:
                    lblTwoTwo.BackColor = color32;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontTen;
                    break;
                case 64:
                    lblTwoTwo.BackColor = color64;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontTen;
                    break;
                case 128:
                    lblTwoTwo.BackColor = color128;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontHundred;
                    break;
                case 256:
                    lblTwoTwo.BackColor = color256;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontHundred;
                    break;
                case 512:
                    lblTwoTwo.BackColor = color512;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontHundred;
                    break;
                case 1024:
                    lblTwoTwo.BackColor = color1024;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontThousand;
                    break;
                case 2048:
                    lblTwoTwo.BackColor = color2048;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoTwo.BackColor = color4096;
                    lblTwoTwo.ForeColor = _textColorWhite;
                    lblTwoTwo.Font = _fontThousand;
                    break;
            }
            // 2, 3
            tileValue = _gameBoard[1, 2];
            switch (tileValue)
            {
                case 0:
                    lblTwoThree.BackColor = color0;
                    lblTwoThree.ForeColor = _textColorBlack;
                    lblTwoThree.Font = _fontTen;
                    break;
                case 2:
                    lblTwoThree.BackColor = color2;
                    lblTwoThree.ForeColor = _textColorBlack;
                    lblTwoThree.Font = _fontTen;
                    break;
                case 4:
                    lblTwoThree.BackColor = color4;
                    lblTwoThree.ForeColor = _textColorBlack;
                    lblTwoThree.Font = _fontTen;
                    break;
                case 8:
                    lblTwoThree.BackColor = color8;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontTen;
                    break;
                case 16:
                    lblTwoThree.BackColor = color16;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontTen;
                    break;
                case 32:
                    lblTwoThree.BackColor = color32;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontTen;
                    break;
                case 64:
                    lblTwoThree.BackColor = color64;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontTen;
                    break;
                case 128:
                    lblTwoThree.BackColor = color128;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontHundred;
                    break;
                case 256:
                    lblTwoThree.BackColor = color256;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontHundred;
                    break;
                case 512:
                    lblTwoThree.BackColor = color512;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontHundred;
                    break;
                case 1024:
                    lblTwoThree.BackColor = color1024;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontThousand;
                    break;
                case 2048:
                    lblTwoThree.BackColor = color2048;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoThree.BackColor = color4096;
                    lblTwoThree.ForeColor = _textColorWhite;
                    lblTwoThree.Font = _fontThousand;
                    break;
            }
            // 2, 4
            tileValue = _gameBoard[1, 3];
            switch (tileValue)
            {
                case 0:
                    lblTwoFour.BackColor = color0;
                    lblTwoFour.ForeColor = _textColorBlack;
                    lblTwoFour.Font = _fontTen;
                    break;
                case 2:
                    lblTwoFour.BackColor = color2;
                    lblTwoFour.ForeColor = _textColorBlack;
                    lblTwoFour.Font = _fontTen;
                    break;
                case 4:
                    lblTwoFour.BackColor = color4;
                    lblTwoFour.ForeColor = _textColorBlack;
                    lblTwoFour.Font = _fontTen;
                    break;
                case 8:
                    lblTwoFour.BackColor = color8;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontTen;
                    break;
                case 16:
                    lblTwoFour.BackColor = color16;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontTen;
                    break;
                case 32:
                    lblTwoFour.BackColor = color32;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontTen;
                    break;
                case 64:
                    lblTwoFour.BackColor = color64;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontTen;
                    break;
                case 128:
                    lblTwoFour.BackColor = color128;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontHundred;
                    break;
                case 256:
                    lblTwoFour.BackColor = color256;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontHundred;
                    break;
                case 512:
                    lblTwoFour.BackColor = color512;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontHundred;
                    break;
                case 1024:
                    lblTwoFour.BackColor = color1024;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontThousand;
                    break;
                case 2048:
                    lblTwoFour.BackColor = color2048;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoFour.BackColor = color4096;
                    lblTwoFour.ForeColor = _textColorWhite;
                    lblTwoFour.Font = _fontThousand;
                    break;
            }


            // 3, 1
            tileValue = _gameBoard[2, 0];
            switch (tileValue)
            {
                case 0:
                    lblThreeOne.BackColor = color0;
                    lblThreeOne.ForeColor = _textColorBlack;
                    lblThreeOne.Font = _fontTen;
                    break;
                case 2:
                    lblThreeOne.BackColor = color2;
                    lblThreeOne.ForeColor = _textColorBlack;
                    lblThreeOne.Font = _fontTen;
                    break;
                case 4:
                    lblThreeOne.BackColor = color4;
                    lblThreeOne.ForeColor = _textColorBlack;
                    lblThreeOne.Font = _fontTen;
                    break;
                case 8:
                    lblThreeOne.BackColor = color8;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontTen;
                    break;
                case 16:
                    lblThreeOne.BackColor = color16;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontTen;
                    break;
                case 32:
                    lblThreeOne.BackColor = color32;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontTen;
                    break;
                case 64:
                    lblThreeOne.BackColor = color64;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontTen;
                    break;
                case 128:
                    lblThreeOne.BackColor = color128;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontHundred;
                    break;
                case 256:
                    lblThreeOne.BackColor = color256;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontHundred;
                    break;
                case 512:
                    lblThreeOne.BackColor = color512;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontHundred;
                    break;
                case 1024:
                    lblThreeOne.BackColor = color1024;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontThousand;
                    break;
                case 2048:
                    lblThreeOne.BackColor = color2048;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeOne.BackColor = color4096;
                    lblThreeOne.ForeColor = _textColorWhite;
                    lblThreeOne.Font = _fontThousand;
                    break;
            }
            // 3, 2
            tileValue = _gameBoard[2, 1];
            switch (tileValue)
            {
                case 0:
                    lblThreeTwo.BackColor = color0;
                    lblThreeTwo.ForeColor = _textColorBlack;
                    lblThreeTwo.Font = _fontHundred;

                    break;
                case 2:
                    lblThreeTwo.BackColor = color2;
                    lblThreeTwo.ForeColor = _textColorBlack;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 4:
                    lblThreeTwo.BackColor = color4;
                    lblThreeTwo.ForeColor = _textColorBlack;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 8:
                    lblThreeTwo.BackColor = color8;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 16:
                    lblThreeTwo.BackColor = color16;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 32:
                    lblThreeTwo.BackColor = color32;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 64:
                    lblThreeTwo.BackColor = color64;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 128:
                    lblThreeTwo.BackColor = color128;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 256:
                    lblThreeTwo.BackColor = color256;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 512:
                    lblThreeTwo.BackColor = color512;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontHundred;
                    break;
                case 1024:
                    lblThreeTwo.BackColor = color1024;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontThousand;
                    break;
                case 2048:
                    lblThreeTwo.BackColor = color2048;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeTwo.BackColor = color4096;
                    lblThreeTwo.ForeColor = _textColorWhite;
                    lblThreeTwo.Font = _fontThousand;
                    break;
            }
            // 3, 3
            tileValue = _gameBoard[2, 2];
            switch (tileValue)
            {
                case 0:
                    lblThreeThree.BackColor = color0;
                    lblThreeThree.ForeColor = _textColorBlack;
                    lblThreeThree.Font = _fontTen;
                    break;
                case 2:
                    lblThreeThree.BackColor = color2;
                    lblThreeThree.ForeColor = _textColorBlack;
                    lblThreeThree.Font = _fontTen;
                    break;
                case 4:
                    lblThreeThree.BackColor = color4;
                    lblThreeThree.ForeColor = _textColorBlack;
                    lblThreeThree.Font = _fontTen;
                    break;
                case 8:
                    lblThreeThree.BackColor = color8;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontTen;
                    break;
                case 16:
                    lblThreeThree.BackColor = color16;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontTen;
                    break;
                case 32:
                    lblThreeThree.BackColor = color32;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontTen;
                    break;
                case 64:
                    lblThreeThree.BackColor = color64;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontTen;
                    break;
                case 128:
                    lblThreeThree.BackColor = color128;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontHundred;
                    break;
                case 256:
                    lblThreeThree.BackColor = color256;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontHundred;
                    break;
                case 512:
                    lblThreeThree.BackColor = color512;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontHundred;
                    break;
                case 1024:
                    lblThreeThree.BackColor = color1024;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontThousand;
                    break;
                case 2048:
                    lblThreeThree.BackColor = color2048;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeThree.BackColor = color4096;
                    lblThreeThree.ForeColor = _textColorWhite;
                    lblThreeThree.Font = _fontThousand;
                    break;
            }
            // 3, 4
            tileValue = _gameBoard[2, 3];
            switch (tileValue)
            {
                case 0:
                    lblThreeFour.BackColor = color0;
                    lblThreeFour.ForeColor = _textColorBlack;
                    lblThreeFour.Font = _fontTen;
                    break;
                case 2:
                    lblThreeFour.BackColor = color2;
                    lblThreeFour.ForeColor = _textColorBlack;
                    lblThreeFour.Font = _fontTen;
                    break;
                case 4:
                    lblThreeFour.BackColor = color4;
                    lblThreeFour.ForeColor = _textColorBlack;
                    lblThreeFour.Font = _fontTen;
                    break;
                case 8:
                    lblThreeFour.BackColor = color8;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontTen;
                    break;
                case 16:
                    lblThreeFour.BackColor = color16;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontTen;
                    break;
                case 32:
                    lblThreeFour.BackColor = color32;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontTen;
                    break;
                case 64:
                    lblThreeFour.BackColor = color64;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontTen;
                    break;
                case 128:
                    lblThreeFour.BackColor = color128;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontHundred;
                    break;
                case 256:
                    lblThreeFour.BackColor = color256;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontHundred;
                    break;
                case 512:
                    lblThreeFour.BackColor = color512;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontHundred;
                    break;
                case 1024:
                    lblThreeFour.BackColor = color1024;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontThousand;
                    break;
                case 2048:
                    lblThreeFour.BackColor = color2048;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeFour.BackColor = color4096;
                    lblThreeFour.ForeColor = _textColorWhite;
                    lblThreeFour.Font = _fontThousand;
                    break;
            }


            // 4, 1
            tileValue = _gameBoard[3, 0];
            switch (tileValue)
            {
                case 0:
                    lblFourOne.BackColor = color0;
                    lblFourOne.ForeColor = _textColorBlack;
                    lblFourOne.Font = _fontTen;

                    break;
                case 2:
                    lblFourOne.BackColor = color2;
                    lblFourOne.ForeColor = _textColorBlack;
                    lblFourOne.Font = _fontTen;
                    break;
                case 4:
                    lblFourOne.BackColor = color4;
                    lblFourOne.ForeColor = _textColorBlack;
                    lblFourOne.Font = _fontTen;
                    break;
                case 8:
                    lblFourOne.BackColor = color8;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontTen;
                    break;
                case 16:
                    lblFourOne.BackColor = color16;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontTen;
                    break;
                case 32:
                    lblFourOne.BackColor = color32;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontTen;
                    break;
                case 64:
                    lblFourOne.BackColor = color64;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontTen;
                    break;
                case 128:
                    lblFourOne.BackColor = color128;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontHundred;
                    break;
                case 256:
                    lblFourOne.BackColor = color256;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontHundred;
                    break;
                case 512:
                    lblFourOne.BackColor = color512;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontHundred;
                    break;
                case 1024:
                    lblFourOne.BackColor = color1024;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontThousand;
                    break;
                case 2048:
                    lblFourOne.BackColor = color2048;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblFourOne.BackColor = color4096;
                    lblFourOne.ForeColor = _textColorWhite;
                    lblFourOne.Font = _fontThousand;
                    break;
            }
            // 4, 2
            tileValue = _gameBoard[3, 1];
            switch (tileValue)
            {
                case 0:
                    lblFourTwo.BackColor = color0;
                    lblFourTwo.ForeColor = _textColorBlack;
                    lblFourTwo.Font = _fontTen;
                    break;
                case 2:
                    lblFourTwo.BackColor = color2;
                    lblFourTwo.ForeColor = _textColorBlack;
                    lblFourTwo.Font = _fontTen;
                    break;
                case 4:
                    lblFourTwo.BackColor = color4;
                    lblFourTwo.ForeColor = _textColorBlack;
                    lblFourTwo.Font = _fontTen;
                    break;
                case 8:
                    lblFourTwo.BackColor = color8;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontTen;
                    break;
                case 16:
                    lblFourTwo.BackColor = color16;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontTen;
                    break;
                case 32:
                    lblFourTwo.BackColor = color32;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontTen;
                    break;
                case 64:
                    lblFourTwo.BackColor = color64;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontTen;
                    break;
                case 128:
                    lblFourTwo.BackColor = color128;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontHundred;
                    break;
                case 256:
                    lblFourTwo.BackColor = color256;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontHundred;
                    break;
                case 512:
                    lblFourTwo.BackColor = color512;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontHundred;
                    break;
                case 1024:
                    lblFourTwo.BackColor = color1024;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontThousand;
                    break;
                case 2048:
                    lblFourTwo.BackColor = color2048;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblFourTwo.BackColor = color4096;
                    lblFourTwo.ForeColor = _textColorWhite;
                    lblFourTwo.Font = _fontThousand;
                    break;
            }
            // 4, 3
            tileValue = _gameBoard[3, 2];
            switch (tileValue)
            {
                case 0:
                    lblFourThree.BackColor = color0;
                    lblFourThree.ForeColor = _textColorBlack;
                    lblFourThree.Font = _fontTen;
                    break;
                case 2:
                    lblFourThree.BackColor = color2;
                    lblFourThree.ForeColor = _textColorBlack;
                    lblFourThree.Font = _fontTen;
                    break;
                case 4:
                    lblFourThree.BackColor = color4;
                    lblFourThree.ForeColor = _textColorBlack;
                    lblFourThree.Font = _fontTen;
                    break;
                case 8:
                    lblFourThree.BackColor = color8;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontTen;
                    break;
                case 16:
                    lblFourThree.BackColor = color16;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontTen;
                    break;
                case 32:
                    lblFourThree.BackColor = color32;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontTen;
                    break;
                case 64:
                    lblFourThree.BackColor = color64;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontTen;
                    break;
                case 128:
                    lblFourThree.BackColor = color128;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontHundred;
                    break;
                case 256:
                    lblFourThree.BackColor = color256;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontHundred;
                    break;
                case 512:
                    lblFourThree.BackColor = color512;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontHundred;
                    break;
                case 1024:
                    lblFourThree.BackColor = color1024;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontThousand;
                    break;
                case 2048:
                    lblFourThree.BackColor = color2048;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblFourThree.BackColor = color4096;
                    lblFourThree.ForeColor = _textColorWhite;
                    lblFourThree.Font = _fontThousand;
                    break;
            }
            // 4, 4
            tileValue = _gameBoard[3, 3];
            switch (tileValue)
            {
                case 0:
                    lblFourFour.BackColor = color0;
                    lblFourFour.ForeColor = _textColorBlack;
                    lblFourFour.Font = _fontTen;
                    break;
                case 2:
                    lblFourFour.BackColor = color2;
                    lblFourFour.ForeColor = _textColorBlack;
                    lblFourFour.Font = _fontTen;
                    break;
                case 4:
                    lblFourFour.BackColor = color4;
                    lblFourFour.ForeColor = _textColorBlack;
                    lblFourFour.Font = _fontTen;
                    break;
                case 8:
                    lblFourFour.BackColor = color8;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontTen;
                    break;
                case 16:
                    lblFourFour.BackColor = color16;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontTen;
                    break;
                case 32:
                    lblFourFour.BackColor = color32;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontTen;
                    break;
                case 64:
                    lblFourFour.BackColor = color64;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontTen;
                    break;
                case 128:
                    lblFourFour.BackColor = color128;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontHundred;
                    break;
                case 256:
                    lblFourFour.BackColor = color256;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontHundred;
                    break;
                case 512:
                    lblFourFour.BackColor = color512;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontHundred;
                    break;
                case 1024:
                    lblFourFour.BackColor = color1024;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontThousand;
                    break;
                case 2048:
                    lblFourFour.BackColor = color2048;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontThousand;
                    break;
                case int n when (tileValue > 2048):
                    lblFourFour.BackColor = color4096;
                    lblFourFour.ForeColor = _textColorWhite;
                    lblFourFour.Font = _fontThousand;
                    break;
            }

        }

        // Updates the game board tiles to represent _gameBoard[,], A '0' is represented by an empty string.
        private void _updateBoard()
        {

            // 1, 1
            if (_gameBoard[0, 0] != 0)
            {
                lblOneOne.Text = _gameBoard[0, 0].ToString();
            }
            else
            {
                lblOneOne.Text = "";
            }
            // 1, 2
            if (_gameBoard[0, 1] != 0)
            {
                lblOneTwo.Text = _gameBoard[0, 1].ToString();
            }
            else
            {
                lblOneTwo.Text = "";
            }
            // 1, 3
            if (_gameBoard[0, 2] != 0)
            {
                lblOneThree.Text = _gameBoard[0, 2].ToString();
            }
            else
            {
                lblOneThree.Text = "";
            }
            // 1, 4
            if (_gameBoard[0, 3] != 0)
            {
                lblOneFour.Text = _gameBoard[0, 3].ToString();
            }
            else
            {
                lblOneFour.Text = "";
            }



            // 2, 1
            if (_gameBoard[1, 0] != 0)
            {
                lblTwoOne.Text = _gameBoard[1, 0].ToString();
            }
            else
            {
                lblTwoOne.Text = "";
            }
            // 2, 2
            if (_gameBoard[1, 1] != 0)
            {
                lblTwoTwo.Text = _gameBoard[1, 1].ToString();
            }
            else
            {
                lblTwoTwo.Text = "";
            }
            // 2, 3
            if (_gameBoard[1, 2] != 0)
            {
                lblTwoThree.Text = _gameBoard[1, 2].ToString();
            }
            else
            {
                lblTwoThree.Text = "";
            }
            // 2, 4
            if (_gameBoard[1, 3] != 0)
            {
                lblTwoFour.Text = _gameBoard[1, 3].ToString();
            }
            else
            {
                lblTwoFour.Text = "";
            }


            // 3, 1
            if (_gameBoard[2, 0] != 0)
            {
                lblThreeOne.Text = _gameBoard[2, 0].ToString();
            }
            else
            {
                lblThreeOne.Text = "";
            }
            // 3, 2
            if (_gameBoard[2, 1] != 0)
            {
                lblThreeTwo.Text = _gameBoard[2, 1].ToString();
            }
            else
            {
                lblThreeTwo.Text = "";
            }
            // 3, 3
            if (_gameBoard[2, 2] != 0)
            {
                lblThreeThree.Text = _gameBoard[2, 2].ToString();
            }
            else
            {
                lblThreeThree.Text = "";
            }
            // 3, 4
            if (_gameBoard[2, 3] != 0)
            {
                lblThreeFour.Text = _gameBoard[2, 3].ToString();
            }
            else
            {
                lblThreeFour.Text = "";
            }


            // 4, 1
            if (_gameBoard[3, 0] != 0)
            {
                lblFourOne.Text = _gameBoard[3, 0].ToString();
            }
            else
            {
                lblFourOne.Text = "";
            }
            // 4, 2
            if (_gameBoard[3, 1] != 0)
            {
                lblFourTwo.Text = _gameBoard[3, 1].ToString();
            }
            else
            {
                lblFourTwo.Text = "";
            }
            // 4, 3
            if (_gameBoard[3, 2] != 0)
            {
                lblFourThree.Text = _gameBoard[3, 2].ToString();
            }
            else
            {
                lblFourThree.Text = "";
            }
            // 4, 4
            if (_gameBoard[3, 3] != 0)
            {
                lblFourFour.Text = _gameBoard[3, 3].ToString();
            }
            else
            {
                lblFourFour.Text = "";
            }
            _updateTileColor();
        }


    }
}
