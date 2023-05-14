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
    /// Interaction logic for RegistrationD.xaml
    /// </summary>
    public partial class RegistrationD : UserControl
    {
        public RegistrationD()
        {
            InitializeComponent();
        }

        private void enterButton_MouseEnter(object sender, MouseEventArgs e)
        {
            enterButton.Foreground = new SolidColorBrush(Color.FromRgb(125, 249, 255));

            DropShadowEffect tempShadow = new DropShadowEffect();
            tempShadow.Color = Color.FromRgb(125, 249, 255);
            tempShadow.Direction = 10;
            tempShadow.ShadowDepth = 1;
            tempShadow.Opacity = 0.1;

            enterButton.Effect = tempShadow;
        }

        private void enterButton_MouseLeave(object sender, MouseEventArgs e)
        {
            enterButton.Foreground = new SolidColorBrush(Color.FromRgb(182, 182, 182));
            enterButton.Effect = null;
        }
    }
}
