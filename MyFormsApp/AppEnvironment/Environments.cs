namespace MyFormsApp.AppEnvironment
{
    public class Environments
    {
        public static Environment Current { set; get; }

        public Environment Debug { get; set; }
        public Environment Release { get; set; }
        public Environment Dev {get; set; }
        public Environment Qa { get; set; }
        public Environment Uat { get; set; }
        public Environment Prod { get; set; }
    }

    public class Environment
    {
        public string BaseApiUrl { get; set; }
        public string AppCenterId { get; set; }
        public string AndroidAppSecret { get; set; }
        public string iOSAppSecret { get; set; }
        public string FirebaseSenderId { get; set; }
    }
}