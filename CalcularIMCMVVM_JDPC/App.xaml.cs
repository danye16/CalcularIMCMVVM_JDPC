using CalcularIMCMVVM_JDPC.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalcularIMCMVVM_JDPC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VCalcularImc();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
