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
using RentCar.service;
using RentCar.entity;

namespace RentCar
{
    /// <summary>
    /// Логика взаимодействия для BufferWindow.xaml
    /// </summary>
    public partial class BufferWindow : Window
    {
        List<Car> cars = new List<Car>();

        public BufferWindow()
        {
            InitializeComponent();

            CarService carService = new CarService();

            cars = carService.GetSubjects();

            carsList.ItemsSource = cars; 
        }


    }
}
