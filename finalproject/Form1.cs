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


        private void txtOneOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTwoOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOneFour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOneThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFourThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThreeFour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTwoThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThreeOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTwoFour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThreeTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFourFour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTwoTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFourTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThreeThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOneTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFourOne_TextChanged(object sender, EventArgs e)
        {

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
                txtOneOne.Text = _gameBoard[0, 0].ToString();
            }
            else
            {
                txtOneOne.Text = "";
            }
            // 1, 2
            if (_gameBoard[0, 1] != 0)
            {
                txtOneTwo.Text = _gameBoard[0, 1].ToString();
            }
            else
            {
                txtOneTwo.Text = "";
            }
            // 1, 3
            if (_gameBoard[0, 2] != 0)
            {
                txtOneThree.Text = _gameBoard[0, 2].ToString();
            }
            else
            {
                txtOneThree.Text = "";
            }
            // 1, 4
            if (_gameBoard[0, 3] != 0)
            {
                txtOneFour.Text = _gameBoard[0, 3].ToString();
            }
            else
            {
                txtOneFour.Text = "";
            }



            // 2, 1
            if (_gameBoard[1, 0] != 0)
            {
                txtTwoOne.Text = _gameBoard[1, 0].ToString();
            }
            else
            {
                txtTwoOne.Text = "";
            }
            // 2, 2
            if (_gameBoard[1, 1] != 0)
            {
                txtTwoTwo.Text = _gameBoard[1, 1].ToString();
            }
            else
            {
                txtTwoTwo.Text = "";
            }
            // 2, 3
            if (_gameBoard[1, 2] != 0)
            {
                txtTwoThree.Text = _gameBoard[1, 2].ToString();
            }
            else
            {
                txtTwoThree.Text = "";
            }
            // 2, 4
            if (_gameBoard[1, 3] != 0)
            {
                txtTwoFour.Text = _gameBoard[1, 3].ToString();
            }
            else
            {
                txtTwoFour.Text = "";
            }


            // 3, 1
            if (_gameBoard[2, 0] != 0)
            {
                txtThreeOne.Text = _gameBoard[2, 0].ToString();
            }
            else
            {
                txtThreeOne.Text = "";
            }
            // 3, 2
            if (_gameBoard[2, 1] != 0)
            {
                txtThreeTwo.Text = _gameBoard[2, 1].ToString();
            }
            else
            {
                txtThreeTwo.Text = "";
            }
            // 3, 3
            if (_gameBoard[2, 2] != 0)
            {
                txtThreeThree.Text = _gameBoard[2, 2].ToString();
            }
            else
            {
                txtThreeThree.Text = "";
            }
            // 3, 4
            if (_gameBoard[2, 3] != 0)
            {
                txtThreeFour.Text = _gameBoard[2, 3].ToString();
            }
            else
            {
                txtThreeFour.Text = "";
            }


            // 4, 1
            if (_gameBoard[3, 0] != 0)
            {
                txtFourOne.Text = _gameBoard[3, 0].ToString();
            }
            else
            {
                txtFourOne.Text = "";
            }
            // 4, 2
            if (_gameBoard[3, 1] != 0)
            {
                txtFourTwo.Text = _gameBoard[3, 1].ToString();
            }
            else
            {
                txtFourTwo.Text = "";
            }
            // 4, 3
            if (_gameBoard[3, 2] != 0)
            {
                txtFourThree.Text = _gameBoard[3, 2].ToString();
            }
            else
            {
                txtFourThree.Text = "";
            }
            // 4, 4
            if (_gameBoard[3, 3] != 0)
            {
                txtFourFour.Text = _gameBoard[3, 3].ToString();
            }
            else
            {
                txtFourFour.Text = "";
            }

        }
    }
}
