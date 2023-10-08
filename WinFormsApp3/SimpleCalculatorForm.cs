namespace WinFormsApp3
{
    public partial class SimpleCalculatorForm : Form
    {
        private float _firstNumber;
        private float _secondNumber;
        private OperationType _operationType;

        private bool _isExpectingSecondNumber;
        private bool _isOperationType;

        private enum OperationType
        {
            Plus,
            Minus,
            Divide,
            Multiply
        }

        public SimpleCalculatorForm()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "1";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 1;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "2";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 2;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "3";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 3;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "4";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 4;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "5";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 5;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "6";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 6;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "7";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 7;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "8";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 8;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text == "0" || _isExpectingSecondNumber)
            {
                _monitorLabel.Text = "9";
                _isExpectingSecondNumber = false;
            }
            else
            {
                _monitorLabel.Text += 9;
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            _isExpectingSecondNumber = true;

            if (_isOperationType)
            {
                _secondNumber = Convert.ToSingle(_monitorLabel.Text);
                string stringResult = (_firstNumber + _secondNumber).ToString();
                _monitorInfoLabel.Text = stringResult + "+";
                _monitorLabel.Text = stringResult;
                _firstNumber = Convert.ToSingle(stringResult);
            }
            else
            {
                _operationType = OperationType.Plus;
                _firstNumber = Convert.ToSingle(_monitorLabel.Text);
                _monitorInfoLabel.Text = _firstNumber + " + ";
                _isOperationType = true;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            _isExpectingSecondNumber = true;

            if (_isOperationType)
            {
                _secondNumber = Convert.ToSingle(_monitorLabel.Text);
                string stringResult = (_firstNumber - _secondNumber).ToString();
                _monitorInfoLabel.Text = stringResult + "-";
                _monitorLabel.Text = stringResult;
                _firstNumber = Convert.ToSingle(stringResult);
            }
            else
            {
                _operationType = OperationType.Minus;
                _firstNumber = Convert.ToSingle(_monitorLabel.Text);
                _monitorInfoLabel.Text = _firstNumber + " - ";
                _isOperationType = true;
            }

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            _isExpectingSecondNumber = true;

            if (_isOperationType)
            {
                _secondNumber = Convert.ToSingle(_monitorLabel.Text);
                string stringResult = (_firstNumber / _secondNumber).ToString();
                _monitorInfoLabel.Text = stringResult + "/";
                _monitorLabel.Text = stringResult;
                _firstNumber = Convert.ToSingle(stringResult);
            }
            else
            {
                _operationType = OperationType.Divide;
                _firstNumber = Convert.ToSingle(_monitorLabel.Text);
                _monitorInfoLabel.Text = _firstNumber + " / ";
                _isOperationType = true;
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _isExpectingSecondNumber = true;

            if (_isOperationType)
            {
                _secondNumber = Convert.ToSingle(_monitorLabel.Text);
                string stringResult = (_firstNumber * _secondNumber).ToString();
                _monitorInfoLabel.Text = stringResult + "*";
                _monitorLabel.Text = stringResult;
                _firstNumber = Convert.ToSingle(stringResult);
            }
            else
            {
                _operationType = OperationType.Multiply;
                _firstNumber = Convert.ToSingle(_monitorLabel.Text);
                _monitorInfoLabel.Text = _firstNumber + " * ";
                _isOperationType = true;
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            _isExpectingSecondNumber = true;

            string stringResult;
            string targetNumber;

            if (_isOperationType)
            {
                _secondNumber = Convert.ToSingle(_monitorLabel.Text);

                targetNumber = _firstNumber.ToString();

                _isOperationType = false;
            }
            else
            {
                targetNumber = _monitorLabel.Text;

                _firstNumber = Convert.ToSingle(_monitorLabel.Text);
            }

            switch (_operationType)
            {
                case OperationType.Plus:
                    stringResult = (_firstNumber + _secondNumber).ToString();
                    _monitorInfoLabel.Text = targetNumber + "+" + _secondNumber + "=";
                    break;
                case OperationType.Minus:
                    stringResult = (_firstNumber - _secondNumber).ToString();
                    _monitorInfoLabel.Text = targetNumber + "-" + _secondNumber + "=";
                    break;
                case OperationType.Divide:
                    stringResult = (_firstNumber / _secondNumber).ToString();
                    _monitorInfoLabel.Text = targetNumber + "/" + _secondNumber + "=";
                    break;
                case OperationType.Multiply:
                    stringResult = (_firstNumber * _secondNumber).ToString();
                    _monitorInfoLabel.Text = targetNumber + "*" + _secondNumber + "=";
                    break;
                default:
                    stringResult = "Не известно";
                    break;
            }

            _monitorLabel.Text = stringResult;
        }

        private void СlearButton_Click(object sender, EventArgs e)
        {
            _firstNumber = 0;
            _secondNumber = 0;

            _monitorLabel.Text = "0";
            _monitorInfoLabel.Text = "";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (_monitorLabel.Text.Length > 1)
            {
                _monitorLabel.Text = _monitorLabel.Text.Remove(_monitorLabel.Text.Length - 1);
            }
            else
            {
                _monitorLabel.Text = "0";
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!_monitorLabel.Text.Contains(','))
            {
                _monitorLabel.Text += ",";
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            decimal number = Convert.ToDecimal(_monitorLabel.Text);
            number *= -1;

            _monitorLabel.Text = number.ToString();
        }

        private void _percentButton_Click(object sender, EventArgs e)
        {
            _isExpectingSecondNumber = true;
            string stringOperationType = "";

            switch (_operationType)
            {
                case OperationType.Plus:
                    stringOperationType = "+";
                    break;
                case OperationType.Minus:
                    stringOperationType = "-";
                    break;
                case OperationType.Divide:
                    stringOperationType = "/";
                    break;
                case OperationType.Multiply:
                    stringOperationType = "*";
                    break;
            }

            if (_isOperationType)
            {
                _secondNumber = Convert.ToSingle(_monitorLabel.Text);
                string stringResult = (_firstNumber * _secondNumber / 100).ToString();
                _monitorInfoLabel.Text = _firstNumber + stringOperationType + stringResult;
                _monitorLabel.Text = stringResult;
                _secondNumber = Convert.ToSingle(stringResult);
            }
            else
            {
                _monitorLabel.Text = "0";
                _monitorInfoLabel.Text = "0";
            }
        }
    }
}
