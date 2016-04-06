using System;

namespace Presentation
{
    public interface ICalculatorView
    {
        void Run();

        object DataContext { get; set; }

        event EventHandler<string> ButtonPressed;

        event EventHandler Loaded;
    }
}