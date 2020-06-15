using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee;

        public Employee Prop { get; set; }

        ObservableCollection<Employee> items;
        public MainWindow()
        {

            Prop = new Employee();
            InitializeComponent();

            items = new ObservableCollection<Employee>()
            {
                new Employee() { Name = "Степан", Surname = "Гладышев", Departament = "Digital" },
                new Employee() { Name = "Семен", Surname = "Кобзев", Departament = "Образования" },
                new Employee() { Name = "Артем", Surname = "Спиридонов", Departament = "Физической культуры" }
            };

            lvEmployee.ItemsSource = items;
            listEmployee.ItemsSource = items;
            employee = new Employee();
        }

        private void listEmployee_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Prop = listEmployee.SelectedItem as Employee;
            //new WindowEdt(this).ShowDialog();
            //var frm = new WindowEdt(listEmployee.SelectedItem as Employee);
            var frm = new WindowEdt(this);
            frm.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(MessageBox.Show("Уверены?", "", MessageBoxButton.OKCancel) == MessageBoxResult.OK))
            {
                e.Cancel = true;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }
        private void AddEmployeeClick(object sender, RoutedEventArgs e)
        {
            {
                employee.items.Add
                (
                new Employee() { Name = "Имя", Surname = "Фамилия", Departament = "Департамент" }
                );
            }
        }
    }
}
