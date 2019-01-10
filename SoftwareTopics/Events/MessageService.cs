using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Events
{
    //Another event.
    public class MessageService
    {
        //eventhandler method.
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message ..." + args.Video.Title);
        }
    }
}
