using System;
using Model;

namespace Presentation
{
    public class CalculatorPresenter : ICalculatorPresenter
    {
        private readonly CalculatorEngine _engine;


        public CalculatorPresenter(ICalculatorView calculatorView)
        {
            _engine = new CalculatorEngine();
            View = calculatorView;
            View.Loaded += OnViewLoaded;
            Initialize(new CalculatorViewModel());
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
            View.ButtonPressed += OnButtonPressed;
        }

        private void OnButtonPressed(object sender, string e)
        {
            if (e == "CE")
                ViewModel.CalculatingString = "";
            else
                ViewModel.CalculatingString += e;

            var result = _engine.Engine(e);
            if (result != "")
                ViewModel.CalculatingString = result;
        }

        public void Run()
        {
            View.Run();
        }
    }
}