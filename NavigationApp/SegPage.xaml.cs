using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationApp
{
    public partial class SegPage : ContentPage
    {
        void Voltar(object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new MainPage());
            Navigation.PopAsync();
        }

        public SegPage()
        {
            InitializeComponent();
        }
    }
}
