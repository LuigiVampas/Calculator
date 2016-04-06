using System;

namespace Presentation
{
    public interface ICalculatorView
    {
        object DataContext { get; set; }

        event EventHandler<string> ButtonPressed;

        event EventHandler Loaded;
    }
}