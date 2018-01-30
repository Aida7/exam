using System;
using System.Collections.Generic;
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

namespace Security
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employ { get; set; }

        //ObservableCollection<Employee> op = new ObservableCollection<Employee>();
        Employee emp = new Employee();
        public MainWindow()
        { 
            InitializeComponent();
            Employ = new ObservableCollection<Employee>();
            Tabl.ItemsSource = Employ;
            List<Employee> list = new List<Employee>
            {
       new Employee { FullName = "Асыл", Id=0, Position = "Директор"},
       new Employee { FullName = "Амир", Id=1,  Position = "Менеджер"},
            };
            Tabl.ItemsSource = list;

        }
        private void Add_Clik(object sender, RoutedEventArgs e)
        {
            emp = new Employee { Id = 0, FullName = "your name", Position = "your position" };
        }

        private void Next_Clik(object sender, RoutedEventArgs e)
        {
            Grid window = new Grid(Employ);
            window.Show();
        }


        private void Delete_Clik(object sender, RoutedEventArgs e)
        {
        Employ.Remove((Employee)Tabl.SelectedItem);
        }

        //private void ButtonSave_Click(object sender, RoutedEventArgs e)
        //{
        //    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ObservableCollection<Employee>));
        //    using (FileStream fs = new FileStream("employee.json", FileMode.OpenOrCreate))
        //    {
        //        jsonFormatter.WriteObject(fs, employers);
        //    }
        //    MessageBox.Show("Сохранено в employee.json");
        //}


    }
}
