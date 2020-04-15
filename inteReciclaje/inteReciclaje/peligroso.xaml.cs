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
    public partial class peligroso : ContentPage
    {
        public peligroso()
        {
            InitializeComponent();
        }
        private void next_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new organico();
        }

        private void goBack_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tiposReciclaje();
        }
    }
}