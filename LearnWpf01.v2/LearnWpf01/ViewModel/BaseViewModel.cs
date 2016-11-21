using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWpf01.ViewModel
{
    class BaseViewModel
    {
        private EmployeeViewModel _evm;
        public BaseViewModel(EmployeeViewModel evm)
        {
            _evm = evm;
        }
    }
}
