using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Warmachine
{
    class MainView : INotifyPropertyChanged
    {

        public int _att;
        public int att
        {
            get
            {
                return _att;
            }
            set
            {
                if (value == _att)
                    return;
                _att = value;
                AttText = _att.ToString();
                OnPropertyChanged();
            }
        }
        public string _AttText;
        public string AttText
        {
            get
            {
                return _AttText;
            }
            set
            {
                if (value == _AttText)
                    return;
                _AttText = value;
                OnPropertyChanged();
            }
        }
        public int _def;
        public int def
        {
            get
            {
                return _def;
            }
            set
            {
                if (value == _def)
                    return;
                _def = value;
                DefText = _def.ToString();
                OnPropertyChanged();
            }
        }
        public string _DefText;
        public string DefText
        {
            get
            {
                return _DefText;
            }
            set
            {
                if (value == _DefText)
                    return;
                _DefText = value;
                OnPropertyChanged();
            }
        }
                public int _arm;
        public int arm
        {
            get
            {
                return _arm;
            }
            set
            {
                if (value == _arm)
                    return;
                _arm = value;
                ArmText = _arm.ToString();
                OnPropertyChanged();
            }
        }
        public string _ArmText;
        public string ArmText
        {
            get
            {
                return _ArmText;
            }
            set
            {
                if (value == _ArmText)
                    return;
                _ArmText = value;
                OnPropertyChanged();
            }
        }
        public string _OutText;
        public string OutText
        {
            get
            {
                return _OutText;
            }
            set
            {
                if (value == _OutText)
                    return;
                _OutText = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
