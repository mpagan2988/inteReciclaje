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
    public partial class welcomePage : ContentPage
    {
        public welcomePage()
        {
            InitializeComponent();
        }

        private void continueBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new dashboard();
        }
    }
}