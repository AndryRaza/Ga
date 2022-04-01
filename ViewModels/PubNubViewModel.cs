using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDesAbsencesv1.Models;
using Ga.Models;
using System.Windows;
using System.ComponentModel;

namespace Ga.ViewModels
{
    public class PubNubViewModel : Notifier
    {
        private PubNubHelper _pubNub = null;
        private string _channelName;

        public string ChannelName { get { return _channelName; } set { _channelName = value; OnPropertyChanged(nameof(ChannelName)); } }

        public PubNubViewModel(string channel)
        {
            ChannelName = channel;
        }

        public void Init()
        {
            var test = ChannelName;
            if (_pubNub == null)
                _pubNub = new PubNubHelper();

            _pubNub.Init(_channelName);
        }

        public void Listen()
        {
            _pubNub.Listen();
        }

        public void PublishMessage(string token)
        {
            _pubNub.Publish(token);
        }


    }

    public class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

