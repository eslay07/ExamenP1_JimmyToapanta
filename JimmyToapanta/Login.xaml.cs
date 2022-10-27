using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JimmyToapanta
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "JimmyToapanta2022";
            string contraseña = "uisrael2022";
            string tUsuario = txtUsuario.Text;
            string tContraseña = txtContraseña.Text;
            if (usuario == tUsuario & contraseña == tContraseña)
            {
                DisplayAlert("Registro de Pagos", "Bienvenido :)", "Cerrar");
                Navigation.PushAsync(new Registro(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario No existe!!", "Cerrar");
            }


        }
    }
}
