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
    /// Логика взаимодействия для ShowRentWindow.xaml
    /// </summary>
    public partial class ShowRentWindow : Window
    {
        List<CarOwn> carOwns = new List<CarOwn>();

        public ShowRentWindow()
        {
            InitializeComponent();

            CarOwnService carOwnService = new CarOwnService();

            carOwns = carOwnService.GetSubjects();

            rentCarsList.ItemsSource = carOwns;
        }
    }
}
