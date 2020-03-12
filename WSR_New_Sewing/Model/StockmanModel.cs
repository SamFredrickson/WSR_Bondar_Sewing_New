using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WSR_New_Sewing.Model
{
    public class StockmanModel : INotifyPropertyChanged
    {

        public int id;
        public string color;
        public string material;
        public decimal width;
        public decimal length;

        public int Ид
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Ид");
            }
        }

        public string Цвет
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Цвет");
            }
        }

        public string Материал
        {
            get { return material; }
            set
            {
                material = value;
                OnPropertyChanged("Материал");
            }
        }

        public decimal Ширина
        {
            get { return width; }
            set
            {
                width = value;
                OnPropertyChanged("Ширина");
            }
        }

        public decimal Длина
        {
            get { return length; }
            set
            {
                length = value;
                OnPropertyChanged("Длина");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
