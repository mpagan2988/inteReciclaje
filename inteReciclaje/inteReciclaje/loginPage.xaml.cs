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
    public partial class loginPage : ContentPage
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void login_btn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new welcomePage();
        }

        private void resetPswrd_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new resetPswrd();
        }
    }
}