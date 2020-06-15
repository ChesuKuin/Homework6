using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Homework_6
{
    public class Employee : INotifyPropertyChanged
    {
        string name;
        string surname;
        string departament;
        private bool flag;
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
            }
        }
        public string Surname
        {
            get { return this.surname; }
            set
            {
                this.surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.surname)));
            }
        }
        public string Departament
        {
            get { return this.departament; }
            set
            {
                this.departament = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.departament)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Employee> items { get; set; }
        public bool Flag
        {
            get { return this.flag; }
            set
            {
                this.flag = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Flag)));
            }
        }
    }
}
