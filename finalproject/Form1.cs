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
