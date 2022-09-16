using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo
{
    public class VMPagina1:BaseViewModel
    {

        #region VARIABLES
        String _Texto;
        #endregion
        #region CONSTRUCTOR

        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion
        #region OBJETOS
        public String Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Alerta()
        {
            await DisplayAlert("Titulo", "cambios", "OK");
        }
        public void ProcesoSimple()
        {

        }

        #endregion
        #region COMANDOS
        public ICommand Alertacommand => new Command(async () => await Alerta());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);

        #endregion

    }
}
