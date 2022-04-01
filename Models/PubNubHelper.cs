using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PubnubApi;
using Ga.Views;
using System.Windows.Navigation;
using System.Windows;

namespace Ga.Models
{
    public class PubNubHelper
    {

        Pubnub pubnub;
        private string ChannelName ;
        NavigationWindow NavigationWindow;
        public void Init(string channelName)
        {
            //Init
            ChannelName = channelName;
            PNConfiguration pnConfiguration = new PNConfiguration("Gestion-Desktop");
            pnConfiguration.SubscribeKey = "sub-c-866a22c2-b18a-11ec-8753-fe86d55faee6";
            pnConfiguration.PublishKey = "pub-c-20c613e5-57f4-498c-b33e-e503064f63a7";

            pubnub = new Pubnub(pnConfiguration);

            //Subscribe
            pubnub.Subscribe<string>()
           .Channels(new string[] {
               ChannelName
           })
           .WithPresence()
           .Execute();
        }

        //Publish a message
        public void Publish(string token)
        {
            JsonMsg Person = new JsonMsg
            {
                Name = "John Doe",
                Description = token,
                Date = DateTime.Now.ToString()
            };

            //Convert to string
            string arrayMessage = JsonConvert.SerializeObject(Person);

            pubnub.Publish()
                .Channel(ChannelName)
                .Message(arrayMessage)
                .Execute(new PNPublishResultExt((result, status) => { }));
        }

        //listen to the channel
        public void Listen()
        {
            SubscribeCallbackExt listenerSubscribeCallack = new SubscribeCallbackExt(
            (pubnubObj, message) => {
                var test = pubnubObj;
                var test_ = message;

                Application.Current.Dispatcher.Invoke((Action)delegate
                {
                    FormerWindow fmw = new();
                    fmw.Show();
                    Application.Current.MainWindow.Close();
                });

         

            },
            (pubnubObj, presence) => {
                // handle incoming presence data
            },
            (pubnubObj, status) => {
                // the status object returned is always related to subscribe but could contain
                // information about subscribe, heartbeat, or errors
                // use the PNOperationType to switch on different options
            });

            pubnub.AddListener(listenerSubscribeCallack);
        }
    }
}
