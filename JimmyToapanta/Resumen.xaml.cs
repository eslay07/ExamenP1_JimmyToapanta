﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JimmyToapanta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen( string usuario, String nombre, string apellido, string carrera, string identificacion, string pMensual)
        {
            InitializeComponent();
            
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCarrera.Text = carrera;
            txtIdentificacion.Text = identificacion;
            pagoM.Text = pMensual + " Dolares Mensuales";

        }
    }
}