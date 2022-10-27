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
            double vAgregado;
            double pMensual;
            double porcentaje =0.03;
            double vAdicional;

            vAgregado = tCurso * porcentaje;
            vAdicional = vAgregado / cuotas;

            pMensual = (mInicial / cuotas) + vAdicional;



        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {

        }
    }
}