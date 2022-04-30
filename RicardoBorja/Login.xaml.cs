using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RicardoBorja
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private int validacion(string usuario, string clave)
        {
            int ok = 0;
            if (usuario == "ricardo2022" && clave == "uisrael2022")
            {
                ok = 1;
            }
            else
            {
                ok = 0;
            }
            return ok;
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            int validar = validacion(txtusuario.Text, txtcontrasena.Text);
            if (validar == 0)
            {
                DisplayAlert("Error", "Usuario o Contraseña Incorrecta", "cerrar");

            }
            else
            {
                Navigation.PushAsync(new Registro(usuario));
            }

            }
    }
}