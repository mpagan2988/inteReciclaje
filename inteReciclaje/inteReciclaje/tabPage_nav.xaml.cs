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
    public partial class tabPage_nav : TabbedPage
    {
        public tabPage_nav()
        {
            InitializeComponent();
        }

        private void typesOfRec_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new tiposReciclaje();
        }

        private void ventajasRec_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ventajas();
        }

        private void desventajasRc_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new desventajas();
        }

        private void termsBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new terms_conditions();
        }
    }
}