using Caliburn.Micro;
using CaliburnMicro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicro.ViewModels
{
    class ShellViewModel : Screen,IScreen ,IHandle<EventMessage>
    {
        private string _messageBox;
        private readonly IEventAggregator _eventAggregator;


        public string MessageBox
        {
            get { return _messageBox; }
            set
            {
                _messageBox = value;
                NotifyOfPropertyChange(() => MessageBox);
            }
        }

        public ShellViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);

        }

        public void OpenWindow()
        {
            WindowManager wm = new WindowManager();
            SecondWindowViewModel swm = new SecondWindowViewModel(_eventAggregator);
            wm.ShowWindow(swm);
        }

        public void Handle(EventMessage message)
        {
            MessageBox = message.Text;
        }
    }
}
