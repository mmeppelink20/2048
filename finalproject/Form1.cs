using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;


namespace finalproject
{
    public partial class Form1 : Form
    {
        private int[,] _gameBoard = new int[3, 3];

        private Color _textColorWhite = Color.White;
        private Color _textColorBlack = Color.Black;

        private Color _color0 = Color.FromArgb(182, 170, 157);

        private Color _color2 = Color.FromArgb(238, 228, 218);
        private Color _color4 = Color.FromArgb(237, 223, 201);
        private Color _color8 = Color.FromArgb(242, 177, 120);
        private Color _color16 = Color.FromArgb(245, 148, 99);

        private Color _color32 = Color.FromArgb(246, 124, 95);
        private Color _color64 = Color.FromArgb(246, 94, 59);
        private Color _color128 = Color.FromArgb(237, 206, 115);
        private Color _color256 = Color.FromArgb(238, 204, 98);

        private Color _color512 = Color.FromArgb(237, 200, 80);
        private Color _color1024 = Color.FromArgb(238, 196, 63);
        private Color _color2048 = Color.FromArgb(237, 194, 46);
        private Color _color4096 = Color.FromArgb(60, 58, 50);

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShiftLogic shiftLogic = new ShiftLogic();
            _gameBoard = shiftLogic.CreateNewGameBoard();
            _updateBoard();
        }
        private void _updateTileColor()
        {
            // 1, 1
            int tileValue = _gameBoard[0, 0];
            switch (tileValue)
            {
                case 0:
                    lblOneOne.BackColor = _color0;
                    lblOneOne.ForeColor = _textColorBlack;
                    break;
                case 2:
                    lblOneOne.BackColor = _color2;
                    lblOneOne.ForeColor = _textColorBlack;
                    break;
                case 4:
                    lblOneOne.BackColor = _color4;
                    lblOneOne.ForeColor = _textColorBlack;
                    break;
                case 8:
                    lblOneOne.BackColor = _color8;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 16:
                    lblOneOne.BackColor = _color16;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 32:
                    lblOneOne.BackColor = _color32;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 64:
                    lblOneOne.BackColor = _color64;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 128:
                    lblOneOne.BackColor = _color128;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 256:
                    lblOneOne.BackColor = _color256;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 512:
                    lblOneOne.BackColor = _color512;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 1024:
                    lblOneOne.BackColor = _color1024;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case 2048:
                    lblOneOne.BackColor = _color2048;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
                case int n when (tileValue > 2048):
                    lblOneOne.BackColor = _color4096;
                    lblOneOne.ForeColor = _textColorWhite;
                    break;
            }
            // 1, 2
            tileValue = _gameBoard[0, 1];
            switch (tileValue)
            {
                case 0:
                    lblOneTwo.BackColor = _color0;
                    lblOneTwo.ForeColor = _textColorBlack;
                    break;
                case 2:
                    lblOneTwo.BackColor = _color2;
                    lblOneTwo.ForeColor = _textColorBlack;
                    break;
                case 4:
                    lblOneTwo.BackColor = _color4;
                    lblOneTwo.ForeColor = _textColorBlack;
                    break;
                case 8:
                    lblOneTwo.BackColor = _color8;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 16:
                    lblOneTwo.BackColor = _color16;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 32:
                    lblOneTwo.BackColor = _color32;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 64:
                    lblOneTwo.BackColor = _color64;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 128:
                    lblOneTwo.BackColor = _color128;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 256:
                    lblOneTwo.BackColor = _color256;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 512:
                    lblOneTwo.BackColor = _color512;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 1024:
                    lblOneTwo.BackColor = _color1024;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case 2048:
                    lblOneTwo.BackColor = _color2048;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
                case int n when (tileValue > 2048):
                    lblOneTwo.BackColor = _color4096;
                    lblOneTwo.ForeColor = _textColorWhite;
                    break;
            }
            // 1, 3
            tileValue = _gameBoard[0, 2];
            switch (tileValue)
            {
                case 0:
                    lblOneThree.BackColor = _color0;
                    lblOneThree.ForeColor = _textColorBlack;
                    break;
                case 2:
                    lblOneThree.BackColor = _color2;
                    lblOneThree.ForeColor = _textColorBlack;
                    break;
                case 4:
                    lblOneThree.BackColor = _color4;
                    lblOneThree.ForeColor = _textColorBlack;
                    break;
                case 8:
                    lblOneThree.BackColor = _color8;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 16:
                    lblOneThree.BackColor = _color16;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 32:
                    lblOneThree.BackColor = _color32;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 64:
                    lblOneThree.BackColor = _color64;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 128:
                    lblOneThree.BackColor = _color128;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 256:
                    lblOneThree.BackColor = _color256;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 512:
                    lblOneThree.BackColor = _color512;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 1024:
                    lblOneThree.BackColor = _color1024;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case 2048:
                    lblOneThree.BackColor = _color2048;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
                case int n when (tileValue > 2048):
                    lblOneThree.BackColor = _color4096;
                    lblOneThree.ForeColor = _textColorWhite;
                    break;
            }
            // 1, 4
            tileValue = _gameBoard[0, 3];
            switch (tileValue)
            {
                case 0:
                    lblOneFour.BackColor = _color0;
                    lblOneFour.ForeColor = _textColorBlack;
                    break;
                case 2:
                    lblOneFour.BackColor = _color2;
                    lblOneFour.ForeColor = _textColorBlack;
                    break;
                case 4:
                    lblOneFour.BackColor = _color4;
                    lblOneFour.ForeColor = _textColorBlack;
                    break;
                case 8:
                    lblOneFour.BackColor = _color8;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 16:
                    lblOneFour.BackColor = _color16;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 32:
                    lblOneFour.BackColor = _color32;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 64:
                    lblOneFour.BackColor = _color64;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 128:
                    lblOneFour.BackColor = _color128;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 256:
                    lblOneFour.BackColor = _color256;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 512:
                    lblOneFour.BackColor = _color512;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 1024:
                    lblOneFour.BackColor = _color1024;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case 2048:
                    lblOneFour.BackColor = _color2048;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
                case int n when (tileValue > 2048):
                    lblOneFour.BackColor = _color4096;
                    lblOneFour.ForeColor = _textColorWhite;
                    break;
            }


            // 2, 1
            tileValue = _gameBoard[1, 0];
            switch (tileValue)
            {
                case 0:
                    lblTwoOne.BackColor = _color0;
                    lblTwoOne.ForeColor = _textColorBlack;
                    break;
                case 2:
                    lblTwoOne.BackColor = _color2;
                    lblTwoOne.ForeColor = _textColorBlack;
                    break;
                case 4:
                    lblTwoOne.BackColor = _color4;
                    lblTwoOne.ForeColor = _textColorBlack;
                    break;
                case 8:
                    lblTwoOne.BackColor = _color8;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 16:
                    lblTwoOne.BackColor = _color16;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 32:
                    lblTwoOne.BackColor = _color32;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 64:
                    lblTwoOne.BackColor = _color64;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 128:
                    lblTwoOne.BackColor = _color128;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 256:
                    lblTwoOne.BackColor = _color256;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 512:
                    lblTwoOne.BackColor = _color512;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 1024:
                    lblTwoOne.BackColor = _color1024;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case 2048:
                    lblTwoOne.BackColor = _color2048;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoOne.BackColor = _color4096;
                    lblTwoOne.ForeColor = _textColorWhite;
                    break;
            }
            // 2, 2
            tileValue = _gameBoard[1, 1];
            switch (tileValue)
            {
                case 0:
                    lblTwoTwo.BackColor = _color0;
                    break;
                case 2:
                    lblTwoTwo.BackColor = _color2;
                    break;
                case 4:
                    lblTwoTwo.BackColor = _color4;
                    break;
                case 8:
                    lblTwoTwo.BackColor = _color8;
                    break;
                case 16:
                    lblTwoTwo.BackColor = _color16;
                    break;
                case 32:
                    lblTwoTwo.BackColor = _color32;
                    break;
                case 64:
                    lblTwoTwo.BackColor = _color64;
                    break;
                case 128:
                    lblTwoTwo.BackColor = _color128;
                    break;
                case 256:
                    lblTwoTwo.BackColor = _color256;
                    break;
                case 512:
                    lblTwoTwo.BackColor = _color512;
                    break;
                case 1024:
                    lblTwoTwo.BackColor = _color1024;
                    break;
                case 2048:
                    lblTwoTwo.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoTwo.BackColor = _color4096;
                    break;
            }
            // 2, 3
            tileValue = _gameBoard[1, 2];
            switch (tileValue)
            {
                case 0:
                    lblTwoThree.BackColor = _color0;
                    break;
                case 2:
                    lblTwoThree.BackColor = _color2;
                    break;
                case 4:
                    lblTwoThree.BackColor = _color4;
                    break;
                case 8:
                    lblTwoThree.BackColor = _color8;
                    break;
                case 16:
                    lblTwoThree.BackColor = _color16;
                    break;
                case 32:
                    lblTwoThree.BackColor = _color32;
                    break;
                case 64:
                    lblTwoThree.BackColor = _color64;
                    break;
                case 128:
                    lblTwoThree.BackColor = _color128;
                    break;
                case 256:
                    lblTwoThree.BackColor = _color256;
                    break;
                case 512:
                    lblTwoThree.BackColor = _color512;
                    break;
                case 1024:
                    lblTwoThree.BackColor = _color1024;
                    break;
                case 2048:
                    lblTwoThree.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoThree.BackColor = _color4096;
                    break;
            }
            // 2, 4
            tileValue = _gameBoard[1, 3];
            switch (tileValue)
            {
                case 0:
                    lblTwoFour.BackColor = _color0;
                    break;
                case 2:
                    lblTwoFour.BackColor = _color2;
                    break;
                case 4:
                    lblTwoFour.BackColor = _color4;
                    break;
                case 8:
                    lblTwoFour.BackColor = _color8;
                    break;
                case 16:
                    lblTwoFour.BackColor = _color16;
                    break;
                case 32:
                    lblTwoFour.BackColor = _color32;
                    break;
                case 64:
                    lblTwoFour.BackColor = _color64;
                    break;
                case 128:
                    lblTwoFour.BackColor = _color128;
                    break;
                case 256:
                    lblTwoFour.BackColor = _color256;
                    break;
                case 512:
                    lblTwoFour.BackColor = _color512;
                    break;
                case 1024:
                    lblTwoFour.BackColor = _color1024;
                    break;
                case 2048:
                    lblTwoFour.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblTwoFour.BackColor = _color4096;
                    break;
            }


            // 3, 1
            tileValue = _gameBoard[2, 0];
            switch (tileValue)
            {
                case 0:
                    lblThreeOne.BackColor = _color0;
                    break;
                case 2:
                    lblThreeOne.BackColor = _color2;
                    break;
                case 4:
                    lblThreeOne.BackColor = _color4;
                    break;
                case 8:
                    lblThreeOne.BackColor = _color8;
                    break;
                case 16:
                    lblThreeOne.BackColor = _color16;
                    break;
                case 32:
                    lblThreeOne.BackColor = _color32;
                    break;
                case 64:
                    lblThreeOne.BackColor = _color64;
                    break;
                case 128:
                    lblThreeOne.BackColor = _color128;
                    break;
                case 256:
                    lblThreeOne.BackColor = _color256;
                    break;
                case 512:
                    lblThreeOne.BackColor = _color512;
                    break;
                case 1024:
                    lblThreeOne.BackColor = _color1024;
                    break;
                case 2048:
                    lblThreeOne.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeOne.BackColor = _color4096;
                    break;
            }
            // 3, 2
            tileValue = _gameBoard[2, 1];
            switch (tileValue)
            {
                case 0:
                    lblThreeTwo.BackColor = _color0;
                    break;
                case 2:
                    lblThreeTwo.BackColor = _color2;
                    break;
                case 4:
                    lblThreeTwo.BackColor = _color4;
                    break;
                case 8:
                    lblThreeTwo.BackColor = _color8;
                    break;
                case 16:
                    lblThreeTwo.BackColor = _color16;
                    break;
                case 32:
                    lblThreeTwo.BackColor = _color32;
                    break;
                case 64:
                    lblThreeTwo.BackColor = _color64;
                    break;
                case 128:
                    lblThreeTwo.BackColor = _color128;
                    break;
                case 256:
                    lblThreeTwo.BackColor = _color256;
                    break;
                case 512:
                    lblThreeTwo.BackColor = _color512;
                    break;
                case 1024:
                    lblThreeTwo.BackColor = _color1024;
                    break;
                case 2048:
                    lblThreeTwo.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeTwo.BackColor = _color4096;
                    break;
            }
            // 3, 3
            tileValue = _gameBoard[2, 2];
            switch (tileValue)
            {
                case 0:
                    lblThreeThree.BackColor = _color0;
                    break;
                case 2:
                    lblThreeThree.BackColor = _color2;
                    break;
                case 4:
                    lblThreeThree.BackColor = _color4;
                    break;
                case 8:
                    lblThreeThree.BackColor = _color8;
                    break;
                case 16:
                    lblThreeThree.BackColor = _color16;
                    break;
                case 32:
                    lblThreeThree.BackColor = _color32;
                    break;
                case 64:
                    lblThreeThree.BackColor = _color64;
                    break;
                case 128:
                    lblThreeThree.BackColor = _color128;
                    break;
                case 256:
                    lblThreeThree.BackColor = _color256;
                    break;
                case 512:
                    lblThreeThree.BackColor = _color512;
                    break;
                case 1024:
                    lblThreeThree.BackColor = _color1024;
                    break;
                case 2048:
                    lblThreeThree.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeThree.BackColor = _color4096;
                    break;
            }
            // 3, 4
            tileValue = _gameBoard[2, 3];
            switch (tileValue)
            {
                case 0:
                    lblThreeFour.BackColor = _color0;
                    break;
                case 2:
                    lblThreeFour.BackColor = _color2;
                    break;
                case 4:
                    lblThreeFour.BackColor = _color4;
                    break;
                case 8:
                    lblThreeFour.BackColor = _color8;
                    break;
                case 16:
                    lblThreeFour.BackColor = _color16;
                    break;
                case 32:
                    lblThreeFour.BackColor = _color32;
                    break;
                case 64:
                    lblThreeFour.BackColor = _color64;
                    break;
                case 128:
                    lblThreeFour.BackColor = _color128;
                    break;
                case 256:
                    lblThreeFour.BackColor = _color256;
                    break;
                case 512:
                    lblThreeFour.BackColor = _color512;
                    break;
                case 1024:
                    lblThreeFour.BackColor = _color1024;
                    break;
                case 2048:
                    lblThreeFour.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblThreeFour.BackColor = _color4096;
                    break;
            }


            // 4, 1
            tileValue = _gameBoard[3, 0];
            switch (tileValue)
            {
                case 0:
                    lblFourOne.BackColor = _color0;
                    break;
                case 2:
                    lblFourOne.BackColor = _color2;
                    break;
                case 4:
                    lblFourOne.BackColor = _color4;
                    break;
                case 8:
                    lblFourOne.BackColor = _color8;
                    break;
                case 16:
                    lblFourOne.BackColor = _color16;
                    break;
                case 32:
                    lblFourOne.BackColor = _color32;
                    break;
                case 64:
                    lblFourOne.BackColor = _color64;
                    break;
                case 128:
                    lblFourOne.BackColor = _color128;
                    break;
                case 256:
                    lblFourOne.BackColor = _color256;
                    break;
                case 512:
                    lblFourOne.BackColor = _color512;
                    break;
                case 1024:
                    lblFourOne.BackColor = _color1024;
                    break;
                case 2048:
                    lblFourOne.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblFourOne.BackColor = _color4096;
                    break;
            }
            // 4, 2
            tileValue = _gameBoard[3, 1];
            switch (tileValue)
            {
                case 0:
                    lblFourTwo.BackColor = _color0;
                    break;
                case 2:
                    lblFourTwo.BackColor = _color2;
                    break;
                case 4:
                    lblFourTwo.BackColor = _color4;
                    break;
                case 8:
                    lblFourTwo.BackColor = _color8;
                    break;
                case 16:
                    lblFourTwo.BackColor = _color16;
                    break;
                case 32:
                    lblFourTwo.BackColor = _color32;
                    break;
                case 64:
                    lblFourTwo.BackColor = _color64;
                    break;
                case 128:
                    lblFourTwo.BackColor = _color128;
                    break;
                case 256:
                    lblFourTwo.BackColor = _color256;
                    break;
                case 512:
                    lblFourTwo.BackColor = _color512;
                    break;
                case 1024:
                    lblFourTwo.BackColor = _color1024;
                    break;
                case 2048:
                    lblFourTwo.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblFourTwo.BackColor = _color4096;
                    break;
            }
            // 4, 3
            tileValue = _gameBoard[3, 2];
            switch (tileValue)
            {
                case 0:
                    lblFourThree.BackColor = _color0;
                    break;
                case 2:
                    lblFourThree.BackColor = _color2;
                    break;
                case 4:
                    lblFourThree.BackColor = _color4;
                    break;
                case 8:
                    lblFourThree.BackColor = _color8;
                    break;
                case 16:
                    lblFourThree.BackColor = _color16;
                    break;
                case 32:
                    lblFourThree.BackColor = _color32;
                    break;
                case 64:
                    lblFourThree.BackColor = _color64;
                    break;
                case 128:
                    lblFourThree.BackColor = _color128;
                    break;
                case 256:
                    lblFourThree.BackColor = _color256;
                    break;
                case 512:
                    lblFourThree.BackColor = _color512;
                    break;
                case 1024:
                    lblFourThree.BackColor = _color1024;
                    break;
                case 2048:
                    lblFourThree.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblFourThree.BackColor = _color4096;
                    break;
            }
            // 4, 4
            tileValue = _gameBoard[3, 3];
            switch (tileValue)
            {
                case 0:
                    lblFourFour.BackColor = _color0;
                    break;
                case 2:
                    lblFourFour.BackColor = _color2;
                    break;
                case 4:
                    lblFourFour.BackColor = _color4;
                    break;
                case 8:
                    lblFourFour.BackColor = _color8;
                    break;
                case 16:
                    lblFourFour.BackColor = _color16;
                    break;
                case 32:
                    lblFourFour.BackColor = _color32;
                    break;
                case 64:
                    lblFourFour.BackColor = _color64;
                    break;
                case 128:
                    lblFourFour.BackColor = _color128;
                    break;
                case 256:
                    lblFourFour.BackColor = _color256;
                    break;
                case 512:
                    lblFourFour.BackColor = _color512;
                    break;
                case 1024:
                    lblFourFour.BackColor = _color1024;
                    break;
                case 2048:
                    lblFourFour.BackColor = _color2048;
                    break;
                case int n when (tileValue > 2048):
                    lblFourFour.BackColor = _color4096;
                    break;
            }

        }
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


        private void btnShiftRight_Click(object sender, EventArgs e)
        {
            ShiftLogic shiftLogic = new ShiftLogic();
            shiftLogic.ShiftBoardRight(_gameBoard);
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {

        }

        private void btnShiftLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {

        }


    }
}
