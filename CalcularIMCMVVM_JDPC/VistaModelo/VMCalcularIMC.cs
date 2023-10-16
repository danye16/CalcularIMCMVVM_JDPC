using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace CalcularIMCMVVM_JDPC.VistaModelo
{
     class VMCalcularIMC : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        double _Peso;
        double _Altura;
        double _IMC;
        #endregion
        #region CONSTRUCTOR
        public VMCalcularIMC(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetos
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public double Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public double Altura
        {
            get { return _Altura; }
            set { SetValue(ref _Altura, value); }
        }
        public double IMC
        {
            get { return _IMC; }
            set { SetValue(ref _IMC, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void CalcularIMC(double p, double a)
        {
            IMC= (p) /(Math.Pow(a, 2));
        }

        public async void BTNCalcularIMC()
        {
            CalcularIMC(Peso, Altura);
            //Declarar variable y asignarle valor
         
            //Realizar el calculo
         


            //enviar resultado

            if (IMC < 18.5)

            {
                Mensaje = "Bajo peso";
            }
            else if (IMC >= 18.5 && IMC < 24.4)

            {
                Mensaje = "Peso normal";
            }
            else if (IMC > 24.9 && IMC<= 29.9)

            {
                Mensaje = "Sobrepeso";
            }
            else if (IMC > 29.9)
            {
                Mensaje = "Tienes obesidad, deja la coca";
            }

           await DisplayAlert("Estado ", Mensaje, "Quitar");
        }
        #endregion
        #region COMMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularIMCCommand => new Command(BTNCalcularIMC);
        #endregion
    }
}
