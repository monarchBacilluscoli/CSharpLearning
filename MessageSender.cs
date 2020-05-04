using System;
using System.Threading;

namespace csharp_test
{
    partial class Program
    {
        class MessageSender
        {
            public void OnVideoEncoded(object source, EventArgs args)
            {
                System.Console.WriteLine("MessageSender: sending message...");
                Thread.Sleep(1000);
                System.Console.WriteLine("MessageSender: Sent");
            }
        }
    }
}
