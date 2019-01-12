using System;
using System.Collections.Generic;
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
using RentCar.entity;
using RentCar.service;

namespace RentCar
{
    /// <summary>
    /// Логика взаимодействия для DeleteCarWindow.xaml
    /// </summary>
    public partial class DeleteCarWindow : Window
    {

        List<Car> cars = new List<Car>();

        public DeleteCarWindow()
        {
            InitializeComponent();

            CarService carService = new CarService();

            cars = carService.GetSubjects();

            carList.ItemsSource = cars;

        }

      
        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idTextBox.Text);

            CarService carService = new CarService();
            carService.DeleteSubjectById(id);
        }
    }
}
