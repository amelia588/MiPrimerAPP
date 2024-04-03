using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyPrimerAPP
{
    public partial class MainPage : ContentPage
    {
        public double numerUno = 0, numerDos = 0, numerRespuesta = 0;
        int operador = 4;
        bool hayPunto = false, unoDecimal = false, dosDecimal = false;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Igualar_valores(string operando, int valor)
        {
            bool validaLbl = lblNumber.Text.GetType() != typeof(string);
            bool validaSpn = spnFirst.Text.GetType() != typeof(string);
            if (numerRespuesta != 0 || ((validaLbl || validaSpn) || (validaLbl && validaSpn)))
                unoDecimal = true;
            if (unoDecimal)
                numerUno = double.Parse(lblNumber.Text);
            else
                numerUno = int.Parse(lblNumber.Text);
            spnFirst.Text = numerUno + "";
            spnFirst.Text = "0";
            spnSecond.Text = operando;
            // Aquí corregimos la asignación del valor a operando
            operando = valor.ToString();
            hayPunto = false;
        }

        private void Btn_sumar(object sender, EventArgs e)
        {

        }
        private void Btn_restar(object sender, EventArgs e)
        {
            // Aquí va tu lógica para el botón de restar
        }
        private void Btn_por(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí

        }
        private void Btn_dividir(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_seven(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_eight(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_nine(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Btn_AC(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_four(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_five(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_six(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_C(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_one(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_two(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_three(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Btn_equals(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_return(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_zero(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
        private void Click_point(object sender, EventArgs e)
        {
            // Tu lógica para el botón de multiplicar va aquí
        }
    }
}
