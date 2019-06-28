using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;

namespace MyFormsApp.Droid
{
    [Activity
     (Label = "SplashActivity",
      MainLauncher = true,
      NoHistory = true,
      Theme = "@style/MainTheme.Splash",
      ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => {
                Intent intent = new Intent(this, typeof(MainActivity));
                if (Intent.Extras != null)
                {
                    //SplashActivity intent is send it to MainActivity to check for remote messages
                    intent.PutExtras(this.Intent);
                }
                intent.AddFlags(ActivityFlags.NoAnimation);
                StartActivity(intent);
            });
            startupWork.Start();
        }

        public override void OnBackPressed() { }
    }
}
