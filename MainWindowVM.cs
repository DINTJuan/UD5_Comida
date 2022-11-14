using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD5_Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<string> tipoPalto;
        private ObservableCollection<Plato> listaPlatos;

        public ObservableCollection<string> TipoComida
        {
            get { return tipoPalto; }
            set
            {
                this.tipoPalto = value;
                this.NotifyPropertyChanged(nameof(TipoComida));
            }
        }

        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }
            set { 
                listaPlatos = value;
                this.NotifyPropertyChanged(nameof(ListaPlatos));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
