using System;

namespace Presentation
{
    public class CalculatorPresenter : ICalculatorPresenter
    {
        public CalculatorPresenter(ICalculatorView calculatorView)
        {
            View = calculatorView;
            View.Loaded += OnViewLoaded;
        }

        public ICalculatorView View { get; set; }

        public CalculatorViewModel ViewModel { get; private set; }

        public void Initialize(CalculatorViewModel viewModel)
        {
            ViewModel = viewModel;
            View.DataContext = ViewModel;
        }

        private void OnViewLoaded(object sender, EventArgs e)
        {
        }
    }
}