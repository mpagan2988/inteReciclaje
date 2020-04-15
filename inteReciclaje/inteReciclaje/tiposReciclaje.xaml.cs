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
    public partial class tiposReciclaje : ContentPage
    {
        public tiposReciclaje()
        {
            InitializeComponent();
        }

        private void matPlastico_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new plasticos ();
        }

        private void matVidrio_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new vidrio ();
        }

        private void matPapel_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new papel();
        }

        private void matPeligroso_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new peligroso();
        }

        private void matOrganico_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new organico ();
        }

        private void matMezclado_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new mezclado ();
        }

        private void goBack_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tabPage_nav();
        }
    }
}