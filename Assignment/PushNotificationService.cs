using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PushNotificationService: INotificationService
    {

        public void SendNotification(string recip, string msg)
        {
            Console.WriteLine($"Sending push notification to {recip}: {msg}");
        }
      
    }
}
