using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Remoting.Messaging;

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
            string result ="";
            result += input;
            bool flag = Int32.TryParse(input, out _num);
            
            if (flag == true)
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


        public void Calculate()
        {
            int num1 = Int32.Parse(_leftOp);
            int num2 = Int32.Parse(_rightOp);

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
                    _rightOp = (Math.Pow(num1, num2)).ToString();
                    break;
                case "%":
                    _rightOp = ((num1 % num2)).ToString();
                    break;
            }
        }
    }
}
