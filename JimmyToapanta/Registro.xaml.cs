using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JimmyToapanta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro( string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = "El usuario conectado es: " + usuario;
           

        }

        private void btnMinicial_Clicked(object sender, EventArgs e)
        {
            double mInicial = Convert.ToDouble(txtMinicial.Text);
            double tCurso = 3000;
            double cuotas = 5;
            double vAgregado;//cantidad total a pagar por el 5% de 3000
            double pMensual;//cantidad que falta pagar + valor mensula del 5%
            double porcentaje =0.05;
            double vAdicionalM;//valor mensual del 5% de 3000 
            double Vpagado;//resta de 3000 - el monto inicial pagado
            double vpagado_cuotas;//cantidad que falta pagar / para 5 cuotas
            double pTotal;

            vAgregado = tCurso * porcentaje;
            vAdicionalM = vAgregado / cuotas;
            Vpagado = tCurso - mInicial;
            vpagado_cuotas = Vpagado / cuotas;
            pMensual = vpagado_cuotas + vAdicionalM;
            pTotal = mInicial + cuotas*(pMensual);
            pagoT.Text = pTotal+"$ Dolares".ToString();

            if (mInicial < tCurso && mInicial>1 )
            {
                pagoM.Text = pMensual+"$ Dolares".ToString();
                

            }
            else if (mInicial < 1)
            {
                DisplayAlert("Error en el ingreso", "Los valores no pueden ser menor a 0", "Cerrar");

            }
            else if(mInicial>tCurso)
                {
                DisplayAlert("Error en el ingreso", "Los valores no pueden ser mayor a 3000", "Cerrar");
            }

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
           

            DisplayAlert("Informacion de Pago", "Guardado Correctamente", "Cerrar");

            Navigation.PushAsync(new Resumen(lbUsuario.Text,txtNombre.Text,txtApellido.Text,txtCarrera.Text,txtIdentificacion.Text,pagoT.Text));


        }

        private void txtMinicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            int mInicial = 0;//declaramos al textbox con valor 0
            int.TryParse(txtMinicial.Text, out mInicial);//en esta linea indicamos que si el valor es borrado o da valor nulo la app no se cuelgue y le asigne el valor 0
            double tCurso = 3000;
            double a = 1;

            if (mInicial > tCurso)
            {
                DisplayAlert("Error en el ingreso", "Los valores no pueden ser mayores a 3000", "Cerrar");
            }
            else if (mInicial < a)
            {

                DisplayAlert("Error en el ingreso", "Los valores no pueden ser menores a 0", "Cerrar");
            }




        }
    }
}