using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyProopertyChangedWPF
{
    public class JuntaNombre : INotifyPropertyChanged
    {
        private string nombre, apellido, nombreCompleto;


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Nombre
        {
            get => nombre;
            set {
                nombre = value;
                OnPropertyChanged(nameof(nombreCompleto));
                    }
        }
        public string Apellido
        {
            get => apellido;
            set { 
                apellido = value;
                OnPropertyChanged(nameof(nombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get => Nombre + Apellido;
            set { }
        }
    }
}
