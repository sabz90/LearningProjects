using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnWpf01.Model;
using System.Collections.ObjectModel;
using LearnWpf01.Framework;
using System.Windows.Input;
using System.ComponentModel;

namespace LearnWpf01.ViewModel
{
    class EmployeeViewModel : INotifyPropertyChanged
    {
        public ICommand ICmd
        {
            get; private set;
        }

        public ICommand EnableButtonCmd
        {
            get; private set;
        }

        public EmployeeViewModel()
        {
            LoadEmployees();
            EnableButtonCmd = new RelayCommand("EnableButtonCmd", CanExecute, Execute);
            ICmd = new RelayCommand("Icommand", CanExecute, Execute);

        }

        public ObservableCollection<IEmployee> Employees
        {
            get;
            set;
        }

        private bool isBtnEnabled = false;



        public bool IsButtonEnabled
        {
            get { return isBtnEnabled; }
            set
            {
                isBtnEnabled = value;
                UpdateProperty("IsButtonEnabled");                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void UpdateProperty(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private bool CanExecute()
        {
            return true;
        }

        private void Execute(object prm)
        {
            if (prm != null)
                IsButtonEnabled = !IsButtonEnabled;
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
