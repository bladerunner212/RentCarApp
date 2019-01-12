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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RentCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = "admin";
            string password = "admin";

            LogWindow logWindow = new LogWindow();


            if (textBoxLogin.Text == String.Empty)
            {
                MessageBox.Show("Введите Ваш логин!");
                //button1.Cursor = Cursors.Hand,Arrow,Wait;
            }
            else
            {
                if (textBoxLogin.Text == login && passwordBox.Password == password)
                {
                    this.Close();
                    logWindow.Show();
                }

                else MessageBox.Show("Вы ввели неверный логин и/или пароль!");
            }
        }


        private void loginAsGuestButton_Click(object sender, RoutedEventArgs e)
        {
            GuestLogWindow guestLogWindow = new GuestLogWindow();
            this.Close();
            guestLogWindow.Show();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            Registration registr = new Registration();

            if (registr.ShowDialog() == true)
            {
                registr.Close();
            }
        }


        private void LoginBox_LostKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (textBoxLogin.Text.Equals(""))
            {
                textBoxLogin.Text = "Username";
                textBoxLogin.Foreground = Brushes.DarkGray;
            }
        }

        private void LoginBox_GotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (textBoxLogin.Text.Equals("Username"))
            {
                textBoxLogin.Text = "";
                textBoxLogin.Foreground = Brushes.Black;
            }
        }


        private void PasswordBox_GotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (passwordBox.Password.Equals("Password"))
            {
                passwordBox.Password = "";
                passwordBox.Foreground = Brushes.Black;
            }

        }

        private void PasswordBox_LostKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (passwordBox.Password.Equals(""))
            {
                passwordBox.Password = "Password";
                passwordBox.Foreground = Brushes.DarkGray;
            }
        }
    }
}
