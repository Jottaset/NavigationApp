using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        void VaiPraProximaPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SegPage());
        }
    }
}
