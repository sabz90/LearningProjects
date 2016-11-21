using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LearnWpf01.Model
{
    class Developer : IEmployee
    {
        public int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            
            set
            {
                if(_age != value)
                {
                    _age = value;
                    
                    RaisePropertyChanged(nameof(Age));
                }
            }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public Sex _sex;
        public Sex Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                if (_sex != value)
                {
                    _sex = value;
                    RaisePropertyChanged("Sex");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
