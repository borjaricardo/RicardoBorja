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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Double cuotaIncial = 0;
            cuotaIncial= Double.Parse(txtCuota.Text);
            Double montoSubTotal=0;
            Double montoMensual = 0;
            Double montoMensualInteres = 0;
            Double montoTotalInteres = 0;
            if (cuotaIncial > 1 && cuotaIncial < 3000)
            {
                montoSubTotal = 3000 - cuotaIncial;
                montoMensual = montoSubTotal / 5;
                montoMensualInteres = montoMensual+((montoMensual * 5) / 100);
                //montoTotalInteres = montoMensualInteres * 5;
                lblMensual.Text = montoMensualInteres.ToString();
                //lblMensual.Text = montoSubTotal.ToString();
            }
            else
            {
                DisplayAlert("Error", "Tu cuota Inicial debe ser menor a $3000 y mayor a $1", "Cerrar");
            } 

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string cantidadTotal = lblMensual.Text;
            Navigation.PushAsync(new Resumen(nombreUsuario,cantidadTotal));
        }
    }
}