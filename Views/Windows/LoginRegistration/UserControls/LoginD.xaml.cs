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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FitnessCenter.Views.Windows.LoginRegistration.UserControls
{
    /// <summary>
    /// Interaction logic for LoginD.xaml
    /// </summary>
    public partial class LoginD : UserControl
    {
        public LoginD()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            loginImg.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(loginBox.Text.Length == 0)
                loginImg.Visibility = Visibility.Visible;
        }

        private void TextBox_LostFocus_1(object sender, RoutedEventArgs e)
        {
            if(loginBox.Text.Length == 0 && textBox.Text.Length == 0)
                passImg.Visibility = Visibility.Visible;

            eyeImg.Visibility = Visibility.Collapsed;
        }

        private void TextBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            passImg.Visibility = Visibility.Collapsed;
            eyeImg.Visibility = Visibility.Visible;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            RegButton.Foreground = new SolidColorBrush(Color.FromRgb(125, 249, 255));

            DropShadowEffect tempShadow = new DropShadowEffect();
            tempShadow.Color = Color.FromRgb(125, 249, 255);
            tempShadow.Direction = 10;
            tempShadow.ShadowDepth = 1;
            tempShadow.Opacity = 0.1;

            RegButton.Effect = tempShadow;
        }

        private void RegButton_MouseLeave(object sender, MouseEventArgs e)
        {
            RegButton.Foreground = new SolidColorBrush(Color.FromRgb(182, 182, 182));
            RegButton.Effect = null;
        }

        private bool isPasswordShown = false;
        private void eyeImg_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isPasswordShown)
            {
                // Hide the password and show the textbox
                passwordBox.Visibility = Visibility.Visible;
                textBox.Visibility = Visibility.Collapsed;
                passwordBox.Password = textBox.Text;
                textBox.Text = "";
                isPasswordShown = false;
            }
            else
            {
                // Show the password and hide the textbox
                passwordBox.Visibility = Visibility.Collapsed;
                textBox.Visibility = Visibility.Visible;
                textBox.Text = passwordBox.Password;
                passwordBox.Password = "";
                isPasswordShown = true;
            }
        }
    }
}
