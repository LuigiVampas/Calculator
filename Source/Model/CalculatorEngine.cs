using System;
using System.Globalization;

namespace Model
{
    public class CalculatorEngine
    {
        private string _rightOp = "";
        private string _leftOp = "";
        private string _operation = "";
        private int _numFromString;

        public string CallEngineCounter(string input)
        {
            var isInt = int.TryParse(input, out _numFromString);
            
            if (isInt)
                if (_operation == "") _leftOp += input;
                else _rightOp += input;   
            else
            {
                switch (input)
                {
                    case "=":
                        CalculateExpression();
                        _operation = "";
                        _rightOp = "";
                        break;
                    case "CE":
                        _leftOp = "";
                        _rightOp = "";
                        _operation = "";
                        break;
                    default:
                        if (_operation != "" && _rightOp != "")
                        {
                            CalculateExpression();
                            _rightOp = "";
                        }
                        _operation = input;
                        break;
                }
            }
            return string.Format("{0}{1}{2}", _leftOp, _operation, _rightOp);
        }

        private void CalculateExpression()
        {
            var num1 = (long)int.Parse(_leftOp);
            var num2 = (long)int.Parse(_rightOp);

            switch (_operation)
            {
                case "+":
                    _leftOp = ((num1 + num2)).ToString();
                    break;
                case "-":
                    _leftOp = ((num1 - num2)).ToString();
                    break;
                case "/":
                    _leftOp = ((num1 / num2)).ToString();
                    break;
                case "*":
                    _leftOp = ((num1 * num2)).ToString();
                    break;
                case "^":
                    _leftOp = (Math.Pow(num1, num2)).ToString(CultureInfo.InvariantCulture);
                    break;
                case "%":
                    _leftOp = ((num1 % num2)).ToString();
                    break;
            }
        }
    }
}
