using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Homework_6
{
    /// <summary>
    /// Логика взаимодействия для WindowEdt.xaml
    /// </summary>
    public partial class WindowEdt : Window
    {

        public WindowEdt()
        {
            InitializeComponent();
            btnOk.Click += delegate { this.DialogResult = true; };
            btnCancel.Click += delegate { this.DialogResult = false; };
        }



        public WindowEdt(MainWindow w) : this()
        {
            mainStackPanel.DataContext = w.Prop;
            Console.WriteLine("----");
            Console.WriteLine(w.Prop.Name);

        }


        public WindowEdt(Employee w) : this()
        {
            mainStackPanel.DataContext = w;
        }
    }
}

