using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegistroContacto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Informacion : ContentPage
    { 
        public Informacion(String nombre, String apellido, String edad, String correo)
        {
            InitializeComponent();
            infnombre.Text = "Nombre: " + nombre + " " + apellido;
            infedad.Text = "Edad: " + edad;
            infcorreo.Text = "Correo: " + correo;
        }
    }
}