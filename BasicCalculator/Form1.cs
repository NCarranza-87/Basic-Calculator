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

        /// <summary>
        /// makes the txtResult invoke ReadOnly, so that a user cannot enter an input
        /// if the user changes txtOperand1, txtOperand2 or txtOperator; then txtResult
        /// will become empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBasicCalculator_Load(object sender, EventArgs e)
        {
            txtResult.ReadOnly = true;
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
            DialogResult exit = MessageBox.Show("Are you sure?", "Quit?",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                Close();
            }
        }

        /// <summary>
        /// gets the input from the user, then calls CalcuateResult() with 
        /// 3 parameters which is assigned to a variable named result. 
        /// After calculation is done, DisplayResult() is called with 
        /// 2 parameters to display the result from the calculation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                string mathOperator = Convert.ToString(txtOperator.Text);
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

                decimal result = CalculateResult(operand1, mathOperator, operand2);

                DisplayResult(result);
            }
        }

        /// <summary>
        /// when BtnCalculate is executed, DisplayResult is called to
        /// display the result of the calculation in txtResult
        /// </summary>
        /// <param name="result"></param>
        private void DisplayResult(decimal result)
        {
            txtResult.Text = Convert.ToString(result.ToString("#.####"));
        }

        /// <summary>
        /// when BtnCalculate is executed, CalculateResult is called
        /// and is assigned to a veriable in BtnCalculate named result
        /// to be used as a parameter in the DisplayResult()
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="mathOperator"></param>
        /// <param name="operand2"></param>
        /// <returns>total is returned when the correpsonding calculation is complete</returns>
        private decimal CalculateResult(decimal operand1, string mathOperator, decimal operand2)
        {
            decimal total = 0;

            switch (mathOperator)
            {
                case "+":
                    total = operand1 + operand2;
                    break;
                case "-":
                    total = operand1 - operand2;
                    break;
                case "*":
                    total = operand1 * operand2;
                    break;
                case "/":
                    total = operand1 / operand2;
                    break;
                default:
                    MessageBox.Show("You must enter a valid math operation");
                    break;
            }
            return total;
        }

        /// <summary>
        /// checks that there is a valid mathematical operation
        /// </summary>
        /// <returns></returns>
        private bool IsOperator()
        {

            if(IsOperatorPresent(txtOperator))
            {
                return true;
            }

            return false;
        }

        private bool IsOperatorPresent(TextBox operationBox)
        {  

            if(operationBox.Text == "+" || operationBox.Text == "-"
                || operationBox.Text == "*" || operationBox.Text == "/")
            {
                return true;
            }
            else
            {
                MessageBox.Show("You entered an invalid math operation.");
                return false;
            }
            
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

        /// <summary>
        /// check if the user input is valid for operandInput1 and
        /// operandInput2; also checks that the input is within range
        /// of 0 and 1,000,000
        /// </summary>
        /// <returns>isDataValid is retured ture or false based
        /// on if the user has the correct input</returns>
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
                else
                {
                    MessageBox.Show("You have entered invalid oerands and cannot calculate.");
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

        
        /// <summary>
        /// check if txtOperand1, txtOperand2 and txtOperator has a text length
        /// greater than zero and clears txtResult
        /// </summary>
        /// <param name="textBox"></param>
        private void ClearResult(TextBox textBox)
        {
            if (textBox.TextLength > 0)
            {
                txtResult.Clear();
            }
        }


        /// <summary>
        /// calls ClearResult() when the user changes 
        /// input in txtOperand1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            ClearResult(txtOperand1);
        }

        /// <summary>
        /// calls ClearResult() when the user changes
        /// input in txtOperator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            ClearResult(txtOperator);
        }

        /// <summary>
        /// callls ClearResult() when the user changes
        /// input in txtOperand2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            ClearResult(txtOperand2);
        }
    }
}
