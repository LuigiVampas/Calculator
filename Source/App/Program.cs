using System;
using System.Windows.Forms;
using Calculator;
using LightInject;
using Presentation;

namespace App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new ServiceContainer();

            container.Register<ICalculatorPresenter, CalculatorPresenter>(new PerContainerLifetime());
            container.Register<ICalculatorView, CalculatorView>(new PerContainerLifetime());

            var presenter = container.GetInstance<ICalculatorPresenter>();
            presenter.Run();
        }
    }
}
