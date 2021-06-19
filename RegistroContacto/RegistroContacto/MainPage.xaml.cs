using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RegistroContacto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void enviarInformacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Informacion(nombreUsuario.Text, apellidoUsuario.Text,edad.Text,correo.Text));
        }
    }
}
