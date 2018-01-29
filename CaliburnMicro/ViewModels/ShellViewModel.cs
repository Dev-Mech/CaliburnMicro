using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicro.ViewModels
{
    class ShellViewModel : Screen
    {
        private string _messageBox;

        public string MessageBox
        {
            get { return _messageBox; }
            set
            {
                _messageBox = value;
                NotifyOfPropertyChange(() => MessageBox);
            }
        }

        public void OpenWindow()
        {
            WindowManager wm = new WindowManager();
            SecondWindowViewModel swm = new SecondWindowViewModel();
            wm.ShowWindow(swm);
        }


    }
}
