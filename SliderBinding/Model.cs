using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliderBinding
{
    public class Model : INotifyPropertyChanged
    {
        private double _volume=50;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Volume 
        {
            get { return _volume.ToString(); }
            set {
                if (double.TryParse(value,out double newValue)&&newValue >= 0 && newValue <= 100)
                {
                    _volume = newValue;
                    OnPropertyChanged(nameof(Volume));
                }
            } 
        }

        public void OnPropertyChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
