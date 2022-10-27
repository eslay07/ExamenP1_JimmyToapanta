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
            string usuario = "1";
            string contraseña = "1";
            string tUsuario = txtUsuario.Text;
            string tContraseña = txtContraseña.Text;
            if (usuario == tUsuario & contraseña == tContraseña)
            {
                DisplayAlert("Registro de Notas", "Bienvenido :)", "Cerrar");
                Navigation.PushAsync(new Registro(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario No existe!!", "Cerrar");
            }


        }
    }
}
