using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace burritoland.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.LoginVM();

            loginBtn.Clicked += DoLogin;
        }

        void DoLogin(object sender, EventArgs e)
        {
            ViewModels.LoginVM loginInstance = (ViewModels.LoginVM)this.BindingContext;
            loginInstance.DoLogin();
        }
    }
}
