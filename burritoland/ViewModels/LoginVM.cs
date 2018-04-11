using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using burritoland.Models;
using Newtonsoft.Json;

namespace burritoland.ViewModels
{
    public class LoginVM : ObservableBaseObject
    {
        private Models.User _user = new Models.User();
        public Models.User user 
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        private bool _incorrectPasswordStatus = false;
        public bool incorrectPasswordStatus
        {
            get
            {
                return _incorrectPasswordStatus;
            }
            set
            {
                _incorrectPasswordStatus = value;
                OnPropertyChanged();
            }
        }

        public LoginVM()
        {
        }

        public async Task DoLogin()
        {
            bool areValidCredentials = await ValidCredentials();
            if(areValidCredentials == true)
            {
                // Jump to another screen
                Xamarin.Forms.Application.Current.MainPage = new Views.Menu();
            }
            else
            {
                // Shows incorrect password message
                incorrectPasswordStatus = true;
            }

        }

        private async Task<bool> ValidCredentials()
        {
            bool result = false;
            try
            {
                using (var httpClient = new HttpClient())
                {
                    string APIUrl = "https://reqres.in/api/login";
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    var userObject = JsonConvert.SerializeObject(user);
                    var stringContent = new StringContent(userObject, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(APIUrl, stringContent);
                    if (response.IsSuccessStatusCode)
                    {
                        // Successful login
                        var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = true;
                    }
                    else
                    {
                        // Something went wrong
                        System.Diagnostics.Debug.WriteLine("Error code: " + response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                // Something went wrong
                System.Diagnostics.Debug.WriteLine(e);
            }
            return result;
        }
    }
}