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
    public partial class registration : ContentPage
    {
        public registration()
        {
            InitializeComponent();
        }

        private void register_btn_Clicked(object sender, EventArgs e)
        {
            String username = username_entry.Text;
            String email = email_entry.Text;
            String password = password_entry.Text;

            if (username != "")
            {
                if (password != "")
                {
                    if(email != "")
                    {
                        DisplayAlert("Advertencia", "Se ha enviado un correo para confirmar su cuenta.", "Intentar otravez");
                    }
                    else
                        DisplayAlert("Advertencia", "Ingrese un correo electronico", "Intentar otravez");
                }
                else
                    DisplayAlert("Advertencia", "Ingrese una contraseña", "Intentar otravez");
            }
            else
                DisplayAlert("Advertencia", "Ingrese nombre de usuario", "Intentar otravez");

            App.Current.MainPage = new MainPage();

        }
    }
}