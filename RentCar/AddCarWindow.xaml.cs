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
    /// Логика взаимодействия для AddCarWindow.xaml
    /// </summary>
    public partial class AddCarWindow : Window
    {
        public AddCarWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (carBrand.Text == "" || carModel.Text == "" || carColor.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                CarService carService = new CarService();
                carService.CreateSubject(carBrand.Text, carModel.Text, 120, 240, null, 10, null, carColor.Text, "Belarus", false);
            }
        }
    }
}
