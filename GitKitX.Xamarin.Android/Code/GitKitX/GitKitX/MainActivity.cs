using Android.App;
using Android.Widget;
using Android.OS;

using GitKitX.APIKit;

namespace GitKitX
{
    [Activity(Label = "GitKitX", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var loginButton = FindViewById<Button>(Resource.Id.buttonLogin);
            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            var userName = FindViewById<EditText>(Resource.Id.editTextUserName).Text;
            var password = FindViewById<EditText>(Resource.Id.editTextPassword).Text;
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password)) return;

            var confirmDialog = new AlertDialog.Builder(this);
            confirmDialog.SetMessage("Login as " + userName + "?");
            confirmDialog.Show();


        }
    }
}

