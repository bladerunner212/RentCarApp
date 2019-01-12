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
    /// Логика взаимодействия для ShowUsersWindow.xaml
    /// </summary>
    public partial class ShowUsersWindow : Window
    {
        List<User> users = new List<User>();

        public ShowUsersWindow()
        {
            InitializeComponent();

            UserService userService = new UserService();

            users = userService.GetSubjects();

            userList.ItemsSource = users;
        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idTextBox.Text);

            UserService userService = new UserService();
            userService.DeleteSubjectById(id);
        }
    }
}
