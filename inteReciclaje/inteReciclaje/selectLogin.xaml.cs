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
    public partial class selectLogin : ContentPage
    {
        public selectLogin()
        {
            InitializeComponent();
        }

        private  void inSesion_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new loginPage();
        }

        private  void registrarse_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new registration();
        }

        private void resetPswrd_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new resetPswrd();
        }
    }
}