using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// checks that there is a valid mathematical operation
        /// </summary>
        /// <returns></returns>
        private string IsOperator()
        {
        }

        private bool IsOperatorPresent(TextBox operationBox, string mathOperation)
        {
            bool hasOperation;

            if(hasOperation.Equals())
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// check that there is data present with in each textbox
        /// </summary>
        /// <returns></returns>
        private bool IsPresent(TextBox box)
        {

            if(box.Text == "")
            {
                return false;
            }

            return true;
        }

        private bool IsDataValid()
        {
            //get the user input
            string operandInput1 = txtOperand1.Text;
            string operandInput2 = txtOperand2.Text;

            bool isDataValid = false;
            //check is input valid
            if(IsDecimal(operandInput1) && IsDecimal(operandInput2))
            {

                //check that both operands are within range of specified values
                if(IsWithinRange(Convert.ToDecimal(operandInput1), 0, 1000000) &&
                    IsWithinRange(Convert.ToDecimal(operandInput2), 0, 1000000))
                {
                    isDataValid = true;
                }
            }

            return isDataValid;
        }

        /// <summary>
        /// check that if a value is within a specifed range
        /// </summary>
        /// <param name="testNumber"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private bool IsWithinRange(decimal testNumber, decimal minValue, decimal maxValue)
        {
            if(testNumber >= minValue && testNumber <= maxValue)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// check if user input is a decimal
        /// for both operands
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsDecimal(string input)
        {
            if (decimal.TryParse(input, out decimal number))
            {
                return true;
            }
            return false;
        }

        /******************************************************
         * these are the function for the operations
         * that a user decides to use for any given calcultion
         *****************************************************/
        private double addOperation()
        {
            return 0;
        }

        private double subtractOperation()
        {
            return 0;
        }

        private double multiplyOperation()
        {
            return 0;
        }

        private double divideOperation()
        {
            return 0;
        }

        /// <summary>
        /// BtnExit is for when the user clicks on Exit button
        /// and calls for the ExitApp function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        /// <summary>
        /// ExitApp() function is to prompt the user if they
        /// wish to either exit or remain in the program
        /// </summary>
        private void ExitApp()
        {
            DialogResult exit = MessageBox.Show("Are you sure?", "Quit?", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                Close();
            }
        }  
    }
}
