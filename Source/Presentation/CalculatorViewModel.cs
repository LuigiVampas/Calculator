using System.ComponentModel;
using System.Runtime.CompilerServices;
using Presentation.Annotations;

namespace Presentation
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private string _calculatingString;

        public string CalculatingString
        {
            get { return _calculatingString; }
            set
            {
                if (value == _calculatingString)
                    return;
                _calculatingString = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}