using System;

namespace Presentation
{
    public interface ICalculatorView
    {
        object DataContext { get; set; }

        event EventHandler<int> NumberPressed;

        event EventHandler<string> SignPressed;
    }
}