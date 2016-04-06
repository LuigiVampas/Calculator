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

        public object DataContext 
        {
            get { return _calculatorViewModelBindingSource.DataSource; }
            set { _calculatorViewModelBindingSource.DataSource = value; }
        }

        private void InvokeButtonPressed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var sign = button.Text;

            if (ButtonPressed != null)
                ButtonPressed(this, sign);
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            if (Loaded != null)
                Loaded(this, EventArgs.Empty);
        }

        public event EventHandler<string> ButtonPressed;

        public event EventHandler Loaded;
    }
}
