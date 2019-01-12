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

namespace RentCar
{
    /// <summary>
    /// Логика взаимодействия для LogWindow.xaml
    /// </summary>
    public partial class LogWindow : Window
    {
        public LogWindow()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void clickDo(object sender, RoutedEventArgs e)
        {
            ShowUsersWindow userWin = new ShowUsersWindow();

            if (userWin.ShowDialog() == true)
            {
                userWin.Close();
            }
        }

        private void userProfileButton_Click(object sender, RoutedEventArgs e)
        {
            UserProfileWindow userWin = new UserProfileWindow();
           
            if (userWin.ShowDialog() == true)
            {
                userWin.Close();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddCarWindow addCarWin = new AddCarWindow();

            if (addCarWin.ShowDialog() == true)
            {
                addCarWin.Close();
            }
           
            
        }

        private void audiButton_Click(object sender, RoutedEventArgs e)
        {
            BufferWindow carsListWin = new BufferWindow();

            if (carsListWin.ShowDialog() == true)
            {
                carsListWin.Close();
            }

        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
