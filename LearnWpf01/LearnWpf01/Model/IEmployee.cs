using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LearnWpf01.Model
{
    interface IEmployee : INotifyPropertyChanged
    {
        string Name { get; set; }

        Sex Sex { get; set; }

        int Age { get; set; }
    }
}
