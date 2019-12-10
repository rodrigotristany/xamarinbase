using System.IO;
using System.Reflection;
using MyFormsApp.AppEnvironment;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MyFormsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetEnvironment();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void SetEnvironment()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("MyFormsApp.AppEnvironment.Environments.json");

            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            Environments env = JsonConvert.DeserializeObject<Environments>(text);

#if __DEV__
            Environments.Current = env.Dev;
#elif __QA__
            Environments.Current = env.Qa;
#elif __UAT__
            Environments.Current = env.Uat;
#elif DEBUG
            Environments.Current = env.Dev;
#else
            Environments.Current = env.Prod;
#endif
        }
    }
}
