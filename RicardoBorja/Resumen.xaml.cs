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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombreUsuario,string subtotal)
        {
            InitializeComponent();
            lblResumenUsuario.Text = nombreUsuario;
            lblResumenTotal.Text = Convert.ToString(Convert.ToDouble(subtotal)*5);
        }
    }
}