using System;
using System.Globalization;

namespace Model
{
    public class CalculatorEngine
    {
        private string _rightOp = "";
        private string _leftOp = "";
        private string _operation = "";

        private int _num;

        public string Engine(string input)
        {
            var result ="";
            var flag = int.TryParse(input, out _num);
            
            if (flag)
                if (_operation == "") _leftOp += input;
                else _rightOp += input;
                
            else
            {
                if (input == "=")
                {
                    Calculate();
                    result += _rightOp;
                    _operation = "";
                }
                else if (input == "CE")
                {
                    _leftOp = "";
                    _rightOp = "";
                    _operation = "";
                    result = "";
                }
                else
                {
                    if (_rightOp != "")
                    {
                        Calculate();
                        _leftOp = _rightOp;
                        _rightOp = "";
                    }
                    _operation = input;
                }
            }
            return result;
        }

        private void Calculate()
        {
            var num1 = int.Parse(_leftOp);
            var num2 = int.Parse(_rightOp);

            switch (_operation)
            {
                case "+":
                    _rightOp = ((num1 + num2)).ToString();
                    break;
                case "-":
                    _rightOp = ((num1 - num2)).ToString();
                    break;
                case "/":
                    _rightOp = ((num1 / num2)).ToString();
                    break;
                case "*":
                    _rightOp = ((num1 * num2)).ToString();
                    break;
                case "^":
                    _rightOp = (Math.Pow(num1, num2)).ToString(CultureInfo.InvariantCulture);
                    break;
                case "%":
                    _rightOp = ((num1 % num2)).ToString();
                    break;
            }
        }
    }
}
