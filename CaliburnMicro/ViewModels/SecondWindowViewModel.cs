using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;

namespace CaliburnMicro.ViewModels
{
    class SecondWindowViewModel: Screen
    {
        private string _secondTextBox;

        public string SecondTextBox
        {
            get { return _secondTextBox; }
            set
            {
                _secondTextBox = value;
                NotifyOfPropertyChange(() => SecondTextBox);
            }
        }

        public void SendBack()
        {
            MessageBox.Show(SecondTextBox,"Testing",MessageBoxButton.OK);
        }

    }
}
