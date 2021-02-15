using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Roma3Assistant.Services;
using Roma3Assistant.Services.Authentication;
using Xamarin.Essentials;
using Roma3Assistant.Models;

namespace Roma3Assistant.View
{
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var username = UserNameInput.Text;
            var password = PasswordInput.Text;
            try
            {
                await AuthenticateUser(username, password);
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                HandleLoginError(ex);
                PasswordInput.Text = string.Empty;
            }
        }

        private async Task AuthenticateUser(string username, string password)
        {
            var authentication = new AuthenticationService(username);
            var accessToken = await authentication.AuthenticateUser(password);
            var userAttributes = AuthenticationService.GetUserAttributes(accessToken);
            TokenResponse token = APIConnector.GetToken(userAttributes.First().Value);
            await SecureStorage.SetAsync("username", userAttributes.First().Value);
            await SecureStorage.SetAsync("accessToken", accessToken);
            await SecureStorage.SetAsync("token", token.ToString());
        }

        private void HandleLoginError(Exception ex)
        {
            Debug.WriteLine(ex.Message);
            _ = DisplayAlert("Error", ex.Message, "Close");
        }
    }
}