using Android.OS;

namespace MyFormsApp.Droid.Messages
{
    public abstract class MessageHandler
    {
        public abstract MessageData ParseMessage(Bundle extras);
    }
}
