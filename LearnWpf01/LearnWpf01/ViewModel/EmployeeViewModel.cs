using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnWpf01.Model;
using System.Collections.ObjectModel;
using LearnWpf01.Framework;
using System.Windows.Input;

namespace LearnWpf01.ViewModel
{
    class EmployeeViewModel
    {
        public ICommand ICmd
        {
            get; private set;
        }
        public EmployeeViewModel()
        {
            LoadEmployees();
            ICmd = new RelayCommand("Icommand", CanExecute, Execute);
        }

        public ObservableCollection<IEmployee> Employees
        {
            get;
            set;
        }

        private bool CanExecute()
        {
            return true;
        }

        private void Execute(object prm)
        {
            int a = 10;
        }

        public void LoadEmployees()
        {
            ObservableCollection<IEmployee> employees = new ObservableCollection<IEmployee>();

            employees.Add(new Developer { Name = "Mark", Age = 24, Sex = Sex.Male});
            employees.Add(new Developer { Name = "Allen", Age = 24, Sex = Sex.Male });
            employees.Add(new Developer { Name = "Linda", Age = 25, Sex = Sex.Female });

            Employees = employees;
        }
    }
}
