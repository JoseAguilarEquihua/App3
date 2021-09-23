using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ViewModels
{
    class NombreViewModel : ViewModelBase
    {


        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;


        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.Equals(nombre, value)) return;
                nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(NombreCompleto));

            }
        }
        public string ApellidoPaterno
        {
            get => apellidoPaterno;
            set
            {
                if (string.Equals(apellidoPaterno, value)) return;
                apellidoPaterno = value;
                RaisePropertyChanged(nameof(ApellidoPaterno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string ApellidoMaterno
        {
            get => apellidoMaterno;
            set
            {
                if (string.Equals(apellidoMaterno, value)) return;
                apellidoMaterno = value;
                RaisePropertyChanged(nameof(ApellidoMaterno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get => string.Format("Tu nombre completo es:\n {0} {1} {2}", nombre, apellidoPaterno, apellidoMaterno);
        }


    }
}
