using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD5_Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;
        private Plato platoSelecionado;

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set { 
                listaPlatos = value;
                this.NotifyPropertyChanged("ListaPlatos");
            }
        }

        public Plato PlatoSelecionado
        {
            get { return platoSelecionado; }
            set
            {
                platoSelecionado = value;
                this.NotifyPropertyChanged("PlatoSelecionado");
            }
        }

        public void QuitarPlato()
        {
            PlatoSelecionado = null;
        }

        public MainWindowVM()
        {
            this.ListaPlatos = Plato.GetSamples(@"C:\2ºDAM\Desarollo de interfaces\1ºTrimestre\UD5\recursos comida\FotosPlatos");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
