
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace BatchLabs.Plugin.Common.Models
{
    public class MaxColorBrush : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private Brush _brush;
        private string _hex;

        public MaxColorBrush(string name, Brush brush)
        {
            _name = name;
            _brush = brush;
            _hex = _brush.ToString();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public Brush Brush
        {
            get { return _brush; }
            set
            {
                _brush = value;
                RaisePropertyChanged();
            }
        }

        public string Hex
        {
            get { return _hex; }
            set
            {
                _hex = value;
                RaisePropertyChanged();
            }
        }


        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
