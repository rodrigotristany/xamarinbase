using System;
using Foundation;
using UserNotifications;

namespace MyFormsApp.iOS.Messages
{
    public abstract class MessageHandler
    {
        public abstract MessageData ParseMessage(string message);

        public abstract void OnMessageReceived();

        public abstract void RegisterForRemoteMessages(Delegate appDelegate);

        public abstract void ReceiveForegorundNotification(NSDictionary userInfo);
    }
}
