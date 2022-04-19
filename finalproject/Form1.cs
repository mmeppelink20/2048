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
            _gameBoard = ShiftLogic.CreateNewGameBoard();


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

            txtOneOne.Text = _gameBoard[0, 0].ToString();
            txtOneTwo.Text - _gameBoard

        }
    }
}
