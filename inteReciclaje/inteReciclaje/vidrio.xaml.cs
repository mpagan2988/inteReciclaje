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
    public partial class vidrio : ContentPage
    {
        public vidrio()
        {
            InitializeComponent();
        }

        private void next_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new papel();
        }

        private void goBack_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tiposReciclaje();
        }
    }
}