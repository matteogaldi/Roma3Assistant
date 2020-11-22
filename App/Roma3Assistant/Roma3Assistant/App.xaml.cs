using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Roma3Assistant
{
    public partial class App
    {
        private string _user;

        public App()
        {
            InitializeComponent();
            _ = GetUser();
            MainPage = _user != null ? new NavigationPage(new MainPage()) : new NavigationPage(new View.LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private async Task GetUser()
        {
            try
            {
                _user = await SecureStorage.GetAsync("username");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}