using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace burritoland.Views
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.MenuVM();
        }
    }
}
