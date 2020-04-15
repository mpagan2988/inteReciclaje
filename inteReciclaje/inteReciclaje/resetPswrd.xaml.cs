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
    public partial class resetPswrd : ContentPage
    {
        public resetPswrd()
        {
            InitializeComponent();
        }

        private void sendMailReset_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Se envio un correo con instrucciones para reestablecer la contraseña", "Continuar");
            App.Current.MainPage = new MainPage();
        }
    }
}