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
using RentCar.dao;

namespace RentCar
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        public void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if(firstName.Text == "" || username.Text == "" || eMail.Text == "" || mobileTel.Text == "" || password.Text == "" || lastName.Text == "")
            {
                MessageBox.Show("Введите данные во всех полях!");
                
               // Console.WriteLine("Записано " + userService.CreateSubject(username.Text, eMail.Text, firstName.Text, lastName.Text, password.Text, mobileTel.Text));
            }
            else
            {
                UserService userService = new UserService();
                userService.CreateSubject(username.Text, eMail.Text, firstName.Text, lastName.Text, password.Text, mobileTel.Text);
                MessageBox.Show("Записано");
            }

            //this.Close();
        }

        public void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
