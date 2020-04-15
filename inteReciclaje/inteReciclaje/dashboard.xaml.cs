using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inteReciclaje
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dashboard : ContentPage
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void foroBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tabPage_nav();
        }

        private void recompensasBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tabPage_nav();
        }

        private void infoBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tabPage_nav();
        }

        private void perfilBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tabPage_nav();
        }

        private void ajustesBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tabPage_nav();
        }
    }
}