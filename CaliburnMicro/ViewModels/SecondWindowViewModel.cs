using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using CaliburnMicro.Models;
using System.Threading;

namespace CaliburnMicro.ViewModels
{
    class SecondWindowViewModel: Screen
    {

        private string _secondTextBox;
        private readonly IEventAggregator _eventAggregator;
        //public EventMessage Tosend = new EventMessage();

        public string SecondTextBox
        {
            get { return _secondTextBox; }
            set
            {
                _secondTextBox = value;
                NotifyOfPropertyChange(() => SecondTextBox);
            }
        }
        


        public SecondWindowViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void SendBack()
        {
            EventMessage ToSend = new EventMessage();
            ToSend.Text = SecondTextBox;
            _eventAggregator.PublishOnUIThread(ToSend);
            Thread.Sleep(1000); //I wanted the app to wait a second before closing
            TryClose();
        }

    }
}
