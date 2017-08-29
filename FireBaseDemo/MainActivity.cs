using Android.App;
using Android.Widget;
using Android.OS;
using Firebase.Analytics;

namespace FireBaseDemo
{
    [Activity(Label = "FireBaseDemo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private FirebaseAnalytics firebaseAnalytics;
        private Button btnMystuff, btnDigest;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            firebaseAnalytics = FirebaseAnalytics.GetInstance(this);

            //btnMystuff = FindViewById<Button>(Resource.)
        }
    }
}

