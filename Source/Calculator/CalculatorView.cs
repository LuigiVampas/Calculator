using System;
using System.Windows.Forms;
using Presentation;

namespace Calculator
{
    public partial class CalculatorView : Form, ICalculatorView
    {
        public CalculatorView()
        {
            InitializeComponent();
        }
        
        private void InvokeNumberButtonPressed(object sender, EventArgs e)
        {
            var button = (Button) sender;
            var number = Convert.ToInt32(button.Text);

            if (NumberPressed != null)
                NumberPressed(this, number);
        }

        private void InvokeSignButtonPressed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var sign = button.Text;

            if (SignPressed != null)
                SignPressed(this, sign);
        }

        public event EventHandler<int> NumberPressed;

        public event EventHandler<string> SignPressed;
    }
}
