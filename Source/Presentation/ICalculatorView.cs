using System;

namespace Presentation
{
    public interface ICalculatorView
    {
        event EventHandler<int> NumberPressed;

        event EventHandler<string> SignPressed;
    }
}